using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem : MonoBehaviour
{

    UIPage PreviousPage;
    UIPage CurrentPage;

    // Start is called before the first frame update
    void Start()
    {
        UIPage[] pages = GetComponentsInChildren<UIPage>(true);
        pages[0].gameObject.SetActive(true);
        for (int i = 1; i < pages.Length; i++)
        {
            pages[i].gameObject.SetActive(false);
        }
        CurrentPage = pages[0];


    }


    public void SwitchPage(UIPage nextPage)
    {

        //TODO: Disable the current page then enable the next page which is 'page'
        PreviousPage = CurrentPage;
        CurrentPage.gameObject.SetActive(false); // disable the gameObject that has the UIPage Compponent
        nextPage.gameObject.SetActive(true);
        CurrentPage = nextPage;

    }

    public void GoToPreviouspage()
    {
        SwitchPage(PreviousPage);
    }






}
