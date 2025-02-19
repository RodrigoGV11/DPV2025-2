using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(superVel(other.gameObject));
            //this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            //this.gameObject.GetComponent<SphereCollider>().enabled = false;
            //Destroy(this.gameObject, 3.0f);
        }
    }

    IEnumerator superVel(GameObject player)
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<SphereCollider>().enabled = false;

        player.GetComponent<CharacterMovement>().setVelocity(10.0f);
        yield return new WaitForSeconds(3.0f);
        player.GetComponent<CharacterMovement>().resetVelocity();

        Destroy(this.gameObject);
    }
}
