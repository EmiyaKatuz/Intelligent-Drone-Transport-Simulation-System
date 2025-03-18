using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Back_School : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }
     void OnClick()
    {
        SceneManager.LoadScene("Version1");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
