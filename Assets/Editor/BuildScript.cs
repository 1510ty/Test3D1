using UnityEditor;

public class BuildScript
{
    public static void PerformBuild()
    {
        // ビルドするシーンを指定
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };

        // 出力先とターゲット
        BuildPipeline.BuildPlayer(
            scenes,
            "build/Test3D1.exe",  // 出力先
            BuildTarget.StandaloneWindows64,
            BuildOptions.None
        );
    }
}
