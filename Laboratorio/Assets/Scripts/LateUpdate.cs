using UnityEngine;

public class lateUpdate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        Debug.Log("Enable");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.Translate(0, 0, 0.1f * Time.deltaTime * 5);
    }
}
