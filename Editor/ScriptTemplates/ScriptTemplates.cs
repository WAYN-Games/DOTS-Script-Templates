using System.Reflection;
using UnityEditor;

namespace WaynGroup.Mgm.Ability.Editor
{
    internal class ScriptTemplates
    {

       
        [MenuItem("Assets/Create/DOTS/Unmanaged System")]
        public static void CreateUnmanagedSystem()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                $"Assets/Editor/ScriptTemplates/UnmanagedSystem.txt",
                "UnmanagedSystem.cs");
        }

        [MenuItem("Assets/Create/DOTS/Autoring Component")]
        public static void CreateAutoringComponent()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                $"Assets/Editor/ScriptTemplates/AutoringComponent.txt",
                "AutoringComponent.cs");
        }

        [MenuItem("Assets/Create/DOTS/IComponentData")]
        public static void CreateIComponentData()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                $"Assets/Editor/ScriptTemplates/IComponentData.txt",
                "AutoringComponent.cs");
        }
        [MenuItem("Assets/Create/DOTS/IBufferElementData")]
        public static void CreateIBufferElementData()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                $"Assets/Editor/ScriptTemplates/IBufferElementData.txt",
                "AutoringComponent.cs");
        }
        [MenuItem("Assets/Create/DOTS/Hybrid Component")]
        public static void CreateHybridComponent()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                $"Assets/Editor/ScriptTemplates/HybridComponent.txt",
                "AutoringComponent.cs");
        }

    }
}