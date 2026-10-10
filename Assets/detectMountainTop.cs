using UnityEngine;

public class detectMountainTop : MonoBehaviour
{
    public GameObject winMessage;
    public GameObject Locomotion;
    public GameObject Sisyphus;
    private Vector3 SisyphusStartPoint;
    private Vector3 StoneStartPoint;
    private bool gameEnd;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SisyphusStartPoint = Sisyphus.transform.position;
        StoneStartPoint = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gameEnd = true;
        Sisyphus.transform.position = SisyphusStartPoint;
        this.gameObject.transform.position = StoneStartPoint;
        Locomotion.SetActive(false);
        winMessage.SetActive(true);
    }
}
