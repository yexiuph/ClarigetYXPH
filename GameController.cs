using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ToggleGroup))]
[RequireComponent(typeof(Image))]
public class GameController : MonoBehaviour
{
    private const int kNumScenes = 6;
    private static List<int> s_SceneList = null;
    public int m_toggle = 0;

    public Image LungHappy;

    //Text txt;

    public void wheezing(){
        m_toggle = 1;
    }
    public void straidor(){
        m_toggle = 2;
    }
    public void rhonochi(){
        m_toggle = 3;
    }
    public void rub(){
        m_toggle = 4;
    }
    public void vesicular(){
        m_toggle = 5;
    }
    public void crackles(){
        m_toggle = 6;
    }


    public void _wheezing(){
        
        //Debug.Log(m_toggle);
        if(m_toggle==1){
            CorrectScene();
        }
        else {

             LungHappy.gameObject.SetActive(false);

        }
    }
    public void _crackles(){
        
        //Debug.Log(m_toggle);
        if(m_toggle==6){
            CorrectScene();
        }
        else {

             LungHappy.gameObject.SetActive(false);

        }
    }
    public void _vesicular(){
        
        //Debug.Log(m_toggle);
        if(m_toggle==5){
            CorrectScene();
        }
        else {

             LungHappy.gameObject.SetActive(false);

        }
    }
    public void _rub(){
        
        //Debug.Log(m_toggle);
        if(m_toggle==4){
            CorrectScene();
        }
        else {

             LungHappy.gameObject.SetActive(false);

        }
    }
    public void _rhonochi(){
        
       // Debug.Log(m_toggle);
        if(m_toggle==3){
            CorrectScene();
        }
        else {

             LungHappy.gameObject.SetActive(false);

        }
    }
    public void _straidor(){
        
        //Debug.Log(m_toggle);
        if(m_toggle==2){
            CorrectScene();
        }
        else {
             LungHappy.gameObject.SetActive(false);

        }
    }


    public void NextScene ()
    {
        if (s_SceneList == null)
        {
            s_SceneList = new List<int> ();
            for (int i = 1; i <= kNumScenes; i++)
            {
                s_SceneList.Add (i);
            }
            for (int i = 0; i < s_SceneList.Count; i++)
            {
                int index = Random.Range (0, s_SceneList.Count);
                s_SceneList.Add (s_SceneList [index]);
                s_SceneList.RemoveAt (index);
            }
        }

        Debug.Log(s_SceneList.Count);

        if (s_SceneList.Count > 0)
        {
            int scene = s_SceneList [0];
            s_SceneList.RemoveAt (0);
            SceneManager.LoadScene(scene);
        }
        if (s_SceneList.Count == 0)
        {
            SceneManager.LoadScene(8);
        }
       


    }

    public void CorrectScene()
    {
        SceneManager.LoadScene(7);
        
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    

}
