using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public Player player;

    // Update is called once per frame
    // void Update()
    // {
            public void onClickSave(){
            // if (Input.GetKeyDown(KeyCode.S))
            // {
                // PlayerPrefsJTA.SetVector2("PlayerV2", player.vector2);
                PlayerPrefsJTA.SetVector3("PlayerV2", player.vector3);
                PlayerPrefsJTA.SetTransform("PlayerTransform", player.transform);
            // }
        }
            public void onClickLoad(){
        // if (Input.GetKeyDown(KeyCode.L))
        // {
            // player.vector2 = PlayerPrefsJTA.GetVector2("PlayerV2");
            player.vector3 = PlayerPrefsJTA.GetVector3("PlayerV2");
            PlayerPrefsJTA.GetTransform("PlayerTransform", player.transform);
        // }
            }
    // }
}


