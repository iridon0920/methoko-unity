using UnityEditor;

public class Builder
{
    public static void Build()
    {
        UnityEditor.AddressableAssets.Settings.AddressableAssetSettings.BuildPlayerContent();

        string[] scenes =
        {
            "Assets/Scenes/SampleScene.unity"
        };
        var options = new BuildPlayerOptions
        {
            target = BuildTarget.WebGL,
            locationPathName = "./Build",
            scenes = scenes
        };
        BuildPipeline.BuildPlayer(options);
    }
}
