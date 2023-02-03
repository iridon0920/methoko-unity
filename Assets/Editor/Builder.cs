using System;
using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Build;
using UnityEngine;

public class Builder
{
    public static void Build()
    {
        var contentStatePath = "Assets/AddressableAssetsData/Windows/addressables_content_state.bin";
        if (File.Exists(contentStatePath))
        {
            ContentUpdateScript.BuildContentUpdate(AddressableAssetSettingsDefaultObject.Settings, contentStatePath);   
        }
        else
        {
            UnityEditor.AddressableAssets.Settings.AddressableAssetSettings.BuildPlayerContent();
        }
    }
}
