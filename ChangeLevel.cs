using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void Change()
    {
        SceneManager.LoadScene("Level1");
    }
}
