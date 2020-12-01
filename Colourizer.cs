using UnityEditor;
using UnityEngine;

public class CustomWindow : EditorWindow
{

    // Variables
    Color color;

    [MenuItem("Tools/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<CustomWindow>("Colorizer");
    }

    // Window display items
    private void OnGUI()
    {
        GUILayout.Label("Color the selected objects", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("Colorize"))
            Colorizer();
    }

    // Methods
    void Colorizer()
    {

        foreach (GameObject g in Selection.gameObjects)
        {
            Renderer ren = g.GetComponent<Renderer>();
            if (ren)
                ren.sharedMaterial.color = color;
        }

    }
}