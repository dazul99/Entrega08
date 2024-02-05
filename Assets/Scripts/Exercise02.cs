using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Exercise02 : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI bottles;

    private string hey;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Song() );
    }

    private IEnumerator Song()
    {
        for(int i = 10; i>0; i--)
        {
            hey = "";
            yield return new WaitForSeconds(0.5f);
            hey += i + " green bottles";
            bottles.text = hey;
            yield return new WaitForSeconds(0.5f);
            hey += "\nHanging on the wall";
            bottles.text = hey;
            yield return new WaitForSeconds(0.5f);
            hey += "\n" + i + " green bottles";
            bottles.text = hey;
            yield return new WaitForSeconds(0.5f);
            hey += "\nHanging on the wall";
            bottles.text = hey;
            yield return new WaitForSeconds(0.5f);
            hey += "\nAnd if one green bottle";
            bottles.text = hey;
            yield return new WaitForSeconds(0.5f);
            hey += "\nShould accidentally fall";
            bottles.text = hey;
            yield return new WaitForSeconds(0.5f);
            hey += "\nThere'll be " + (i-1) + " green bottles";
            bottles.text = hey;
            yield return new WaitForSeconds(0.5f);
            hey += "\nHanging on the wall";
            bottles.text = hey;
        }
        yield return new WaitForSeconds(0.5f);
        bottles.text = "There are no more bottles";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
