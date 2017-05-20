using UnityEditor;
using UnityEngine;

public static class QuarterView
{
    [InitializeOnLoadMethod]
    private static void Example()
    {
        var forward = Quaternion.LookRotation(new Vector3(-1, -1, 1));
        var rect = new Rect(8, 24, 80, 0);

        SceneView.onSceneGUIDelegate += sceneView =>
        {
            GUI.WindowFunction func = id =>
            {
                if (GUILayout.Button("Quarter"))
                {
                    sceneView.rotation = forward;
                }
            };
            GUILayout.Window(1, rect, func, string.Empty);
        };
    }
}