﻿using System;
using Megumin.GameFramework.AI.Editor;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Megumin.GameFramework.AI.BehaviorTree.Editor
{
    public class BehaviorTreeEditor : EditorWindow
    {
        [OnOpenAsset(10)]
        public static bool OnOpenAsset(int instanceID, int line, int column)
        {
            var asset = EditorUtility.InstanceIDToObject(instanceID);

            if (asset is BehaviorTreeAsset behaviorTreeAsset)
            {
                var wnd = GetWindow(behaviorTreeAsset);
                wnd.SelectTree(behaviorTreeAsset);
                wnd.UpdateTitle();
                return true;
            }

            //TODO Json

            return false;
        }

        [SerializeField]
        private VisualTreeAsset m_VisualTreeAsset = default;

        public BehaviorTreeView TreeView { get; private set; }
        public BehaviorTreeAsset CurrentAsset { get; private set; }

        [MenuItem("Megumin AI/BehaviorTreeEditor")]
        public static void ShowExample()
        {
            var wnd = GetWindow();
            wnd.UpdateTitle();
        }

        private static BehaviorTreeEditor GetWindow(UnityEngine.Object asset = null)
        {
            BehaviorTreeEditor[] array = Resources.FindObjectsOfTypeAll(typeof(BehaviorTreeEditor)) as BehaviorTreeEditor[];
            if (array != null)
            {
                foreach (var item in array)
                {
                    if (item)
                    {
                        if (item.CurrentAsset == asset)
                        {
                            Debug.Log($"找到匹配的已打开EditorWindow {asset}");
                            item.Focus();
                            item.UpdateTitle();
                            item.UpdateHasUnsavedChanges();
                            return item;
                        }
                    }
                }
            }

            BehaviorTreeEditor wnd = CreateWindow<BehaviorTreeEditor>(typeof(BehaviorTreeEditor), typeof(SceneView));

            return wnd;
        }

        public void UpdateTitle()
        {
            if (CurrentAsset)
            {
                this.titleContent = new GUIContent(CurrentAsset.name);
            }
            else
            {
                this.titleContent = new GUIContent("BehaviorTreeEditor");
            }
        }

        public void UpdateSaveMessage()
        {
            if (CurrentAsset)
            {
                saveChangesMessage = $"{CurrentAsset.name} 有未保存改动";
            }
            else
            {
                saveChangesMessage = $"当前窗口有未保存改动";
            }
        }

        public void UpdateHasUnsavedChanges()
        {
            hasUnsavedChanges = TreeView?.SOTree?.ChangeVersion != SaveVersion;
            UpdateSaveMessage();
        }

        public void Update()
        {

        }

        public void CreateGUI()
        {
            VisualElement root = rootVisualElement;
            root.AddToClassList("behaviorTreeEditor");

            // Instantiate UXML
            //VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
            //labelFromUXML.name = "BehaviorTreeEditor";
            //labelFromUXML.StretchToParentSize();
            //root.Add(labelFromUXML);

            ///CloneTree可以避免生成TemplateContainer
            m_VisualTreeAsset.CloneTree(root);

            TreeView = root.Q<BehaviorTreeView>("behaviorTreeView");
            TreeView.EditorWindow = this;

            CreateTopbar();
        }

        static MySetting<bool> showFloatingTip = new MySetting<bool>("behaviorTreeEditor.showFloatingTip", true, SettingsScope.User);

        private void CreateTopbar()
        {
            VisualElement root = rootVisualElement;
            var toolbar = root.Q<Toolbar>("toolbar");

            var save = root.Q<ToolbarButton>("saveAsset");
            save.clicked += SaveAsset;

            var saveAs = root.Q<ToolbarMenu>("saveAs");
            saveAs.menu.AppendAction("Save as Json", SaveTreeAsJson, a => DropdownMenuAction.Status.Normal);
            saveAs.menu.AppendAction("Save as ScriptObject",
                                     a => CreateScriptObjectTreeAssset(),
                                     a => DropdownMenuAction.Status.Normal);

            var showInProject = root.Q<ToolbarButton>("showInProject");
            showInProject.clicked += ShowInProject;

            var file = root.Q<ToolbarMenu>("file");
            file.menu.AppendAction("Default is never shown", a => { }, a => DropdownMenuAction.Status.None);
            file.menu.AppendAction("Normal file", a => { }, a => DropdownMenuAction.Status.Normal);
            file.menu.AppendAction("Hidden is never shown", a => { }, a => DropdownMenuAction.Status.Hidden);
            file.menu.AppendAction("Checked file", a => { }, a => DropdownMenuAction.Status.Checked);
            file.menu.AppendAction("Disabled file", a => { }, a => DropdownMenuAction.Status.Disabled);
            file.menu.AppendAction("Disabled and checked file", a => { }, a => DropdownMenuAction.Status.Disabled | DropdownMenuAction.Status.Checked);

            file.menu.AppendAction("Save", a => SaveAsset(), a => DropdownMenuAction.Status.Normal);

            var showTree = root.Q<ToolbarButton>("showTreeWapper");
            showTree.clicked += () => TreeView?.InspectorShowWapper();

            var reloadView = root.Q<ToolbarButton>("reloadView");
            reloadView.clicked += () => TreeView?.ReloadView(true);

            var test1 = root.Q<ToolbarButton>("test1");
            test1.clicked += () =>
            {

            };

            var test2 = root.Q<ToolbarButton>("test2");
            test2.clicked += () =>
            {

            };

            var test3 = root.Q<ToolbarButton>("test3");
            test3.clicked += () =>
            {

            };



            var showFloatingTipToggle = root.Q<ToolbarToggle>("showFloatingTip");
            showFloatingTipToggle.value = showFloatingTip.value;
            TreeView.FloatingTip.Show(showFloatingTip.value);

            showFloatingTipToggle.RegisterValueChangedCallback(evt =>
            {
                showFloatingTip.SetValue(evt.newValue);
                TreeView.FloatingTip.Show(evt.newValue);
            });
        }

        public void ShowInProject()
        {
            if (CurrentAsset)
            {
                Selection.activeObject = CurrentAsset;
            }
        }

        public int SaveVersion = 0;
        public void SaveAsset()
        {
            if (TreeView?.SOTree?.ChangeVersion == SaveVersion)
            {
                Debug.Log($"没有需要保存的改动。");
                return;
            }

            if (!CurrentAsset)
            {
                CurrentAsset = CreateScriptObjectTreeAssset();
            }

            if (!CurrentAsset)
            {
                Debug.LogError($"保存资源失败，没有找到Asset文件");
                return;
            }

            var success = CurrentAsset.SaveTree(TreeView.Tree);
            if (success)
            {
                SaveVersion = TreeView.SOTree.ChangeVersion;
                UpdateHasUnsavedChanges();
                EditorUtility.SetDirty(CurrentAsset);
                AssetDatabase.SaveAssetIfDirty(CurrentAsset);
                AssetDatabase.Refresh();
                Debug.Log($"保存资源成功");
            }
            else
            {
                Debug.Log($"保存资源失败");
            }
        }

        public BehaviorTreeAsset CreateScriptObjectTreeAssset()
        {
            var path = EditorUtility.SaveFilePanelInProject("保存", "BTtree", "asset", "test");
            if (!string.IsNullOrEmpty(path))
            {
                Debug.Log(path);
                var tree = ScriptableObject.CreateInstance<BehaviorTreeAsset>();
                AssetDatabase.CreateAsset(tree, path);
                AssetDatabase.Refresh();
                return tree;
            }

            return null;
        }

        private void SaveTreeAsJson(DropdownMenuAction obj)
        {
            var path = EditorUtility.SaveFilePanelInProject("保存", "BTJson", "json", "test");
            if (!string.IsNullOrEmpty(path))
            {
                Debug.Log(path);
                TextAsset json = new TextAsset("{Tree}");
                AssetDatabase.CreateAsset(json, path);
                AssetDatabase.Refresh();
            }
        }

        public void OnEnable()
        {

        }

        private void OnDestroy()
        {
            TreeView?.Dispose();
        }

        public void SelectTree(BehaviorTreeAsset behaviorTreeAsset)
        {
            this.LogFuncName();
            this.CurrentAsset = behaviorTreeAsset;
            TreeView.ReloadView(true);
        }

        public override void DiscardChanges()
        {
            base.DiscardChanges();
            this.LogFuncName();
        }

        public override void SaveChanges()
        {
            base.SaveChanges();
            this.LogFuncName();
        }
    }
}

