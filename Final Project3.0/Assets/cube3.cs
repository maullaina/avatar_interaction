using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube3 : MonoBehaviour
{
    #region Attributed
    public Transform thirdcube;
    public Vector3 returnPosition;
    public Vector3 jumpPosition;
    public float jumpSpeed = 5;
    private bool jump = false;
    #endregion

    #region Monobehaviour API
    void Update()
    {
        if (jump)
        {
            thirdcube.position = Vector3.Lerp(thirdcube.position, jumpPosition, Time.deltaTime * jumpSpeed);
        }
        else
        {
            thirdcube.position = Vector3.Lerp(thirdcube.position, returnPosition, Time.deltaTime * jumpSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "footL")
        {
            jumpCube();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "footL")
        {
            returnCube();
        }
    }

    #endregion
    public void returnCube()
    {
        jump = false;
    }
    public void jumpCube()
    {
        jump = true;
    }

}
