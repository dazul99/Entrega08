using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI letter;

    [SerializeField] private string phrase;

    private string resul = "";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Write());
    }

    private IEnumerator Write()
    {
        for (int i = 0; i < phrase.Length; i++)
        {
            resul += phrase[i];
            letter.text = "Exercise 3\n" + resul;
            yield return new WaitForSeconds(0.2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
