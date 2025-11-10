using UnityEngine;

[RequireComponent(typeof(Camera))]
public class AdjustOrthographicSize : MonoBehaviour
{
    
    private Camera cam;
    private Vector2 vcur = new Vector2(Screen.width, Screen.height);

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // If screen size changes (rotation)
        if (vcur.x != Screen.width || vcur.y != Screen.height)
        {
            vcur.x = Screen.width;
            vcur.y = Screen.height;
            AdjustSize();
        }
    }

    void AdjustSize()
    {
        cam.orthographicSize = cam.orthographicSize*((float)Screen.height / (float)Screen.width);
    }
}