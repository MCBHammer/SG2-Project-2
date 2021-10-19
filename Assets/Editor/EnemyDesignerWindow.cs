using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemyDesignerWindow : EditorWindow
{
    Texture2D headerSectionTexture;
    Texture2D mageSectionTexture;
    Texture2D warriorSectionTexture;
    Texture2D rogueSectionTexture;

    Color headerSectionColor = new Color(13f / 255f, 32f / 255f, 44f / 255f, 1f);

    Rect headerSection;
    Rect mageSection;
    Rect warriorSection;
    Rect rogueSection;

    [MenuItem("Window/Enemy Designer")]
    static void OpenWindow()
    {
        EnemyDesignerWindow window = (EnemyDesignerWindow)GetWindow(typeof(EnemyDesignerWindow));
        window.minSize = new Vector2(600, 300);
        //window.maxSize
        window.Show();
    }

    void OnEnable()
    {
        InitTextures();
    }

    void InitTextures()
    {
        headerSectionTexture = new Texture2D(1, 1);
        headerSectionTexture.SetPixel(0, 0, headerSectionColor);
        headerSectionTexture.Apply();

        //maybe use textures in resources
        mageSectionTexture = new Texture2D(1, 1);
        mageSectionTexture.SetPixel(0, 0, new Color(0f, 0f, 1f, 1f));
        mageSectionTexture.Apply();

        warriorSectionTexture = new Texture2D(1, 1);
        warriorSectionTexture.SetPixel(0, 0, new Color(1f, 0f, 0f, 1f));
        warriorSectionTexture.Apply();

        rogueSectionTexture = new Texture2D(1, 1);
        rogueSectionTexture.SetPixel(0, 0, new Color(0f, 1f, 0f, 1f));
        rogueSectionTexture.Apply();
    }

    void OnGUI()
    {
        DrawLayouts();
        DrawHeader();
        DrawMageSettings();
        DrawWarriorSettings();
        DrawRogueSettings();
    }

    void DrawLayouts()
    {
        headerSection.x = 0;
        headerSection.y = 0;
        headerSection.width = Screen.width;
        headerSection.height = 50;

        mageSection.x = 0;
        mageSection.y = headerSection.height;
        mageSection.width = (Screen.width/3f);
        mageSection.height = Screen.height - headerSection.height;

        warriorSection.x = (Screen.width / 3f);
        warriorSection.y = headerSection.height;
        warriorSection.width = (Screen.width / 3f);
        warriorSection.height = Screen.height - headerSection.height;

        rogueSection.x = (Screen.width / 3f) * 2;
        rogueSection.y = headerSection.height;
        rogueSection.width = (Screen.width / 3f);
        rogueSection.height = Screen.height - headerSection.height;

        GUI.DrawTexture(headerSection, headerSectionTexture);
        GUI.DrawTexture(mageSection, mageSectionTexture);
        GUI.DrawTexture(warriorSection, warriorSectionTexture);
        GUI.DrawTexture(rogueSection, rogueSectionTexture);
    }

    void DrawHeader()
    {
        GUILayout.BeginArea(headerSection);



        GUILayout.EndArea();
    }

    void DrawMageSettings()
    {
        GUILayout.BeginArea(mageSection);



        GUILayout.EndArea();
    }

    void DrawWarriorSettings()
    {
        GUILayout.BeginArea(warriorSection);



        GUILayout.EndArea();
    }

    void DrawRogueSettings()
    {
        GUILayout.BeginArea(rogueSection);



        GUILayout.EndArea();
    }
}
