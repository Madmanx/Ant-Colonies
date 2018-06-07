using UnityEngine;

[CreateAssetMenu(fileName = "AntSpecie", menuName = "Custom/AntSpecie", order = 2)]
[System.Serializable]
public class AntSpecie : ScriptableObject {

    [Header("Head")]
    [SerializeField]
    [Range(0.8f, 1.2f)]
    public float headSize = 1.0f;
    [SerializeField]
    public Color headColor;
    [SerializeField]
    public GameObject Head;

    [Header("Thorax")]
    [SerializeField]
    [Range(0.8f, 1.2f)]
    public float thoraxSize = 1.0f;
    [SerializeField]
    public Color thoraxColor;
    [SerializeField]
    public GameObject Thorax;

    [Header("Abdomen")]
    [SerializeField]
    [Range(0.8f, 1.2f)]
    public float abdomenSize = 1.0f;
    [SerializeField]
    public Color abdomenColor;
    [SerializeField]
    public GameObject Abdomen;
}
