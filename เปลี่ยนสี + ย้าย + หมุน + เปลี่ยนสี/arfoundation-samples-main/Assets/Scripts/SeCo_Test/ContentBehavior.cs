using UnityEngine;

public class ContentBehavior : MonoBehaviour
{
    [SerializeField]
    Renderer rend;

    void Start() {
        ChangeColorButtonDown();
    }

    public void ChangeColorButtonDown() {
        Color col = new Color(GetRandNum(), GetRandNum(), GetRandNum());
        rend.material.color = col;
    }

    public void RemoveButtonDown() {
        Destroy(gameObject);
    }

    float GetRandNum() {
        return Random.Range(0f, 1f);
    }
}
