using UnityEditor;

public class Builder
{
    public static void Build()
    {
        UnityEditor.AddressableAssets.Settings.AddressableAssetSettings.BuildPlayerContent();
    }
}
