using UnityEngine;
using UnityEngine.UI;

public class MediaPlayer : Screen
{

    [SerializeField]
    RawImage mediaImage;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        CloseScreen();
        
    }

    public void OpenScreen(Texture imageTex) {
        mediaImage.texture = imageTex;
        SetScreen(true);
    }

    public void CloseScreen() {
        SetScreen(false);
    }
}
