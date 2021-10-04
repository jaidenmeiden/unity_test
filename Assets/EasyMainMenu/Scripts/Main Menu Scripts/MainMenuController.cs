using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    Animator anim;

    public string newGameSceneName;
    public int quickSaveSlotID;

    [Header("Options Panel")]
    public GameObject MainOptionsPanel;
    public GameObject StartGameOptionsPanel;
    public GameObject GamePanel;
    public GameObject ControlsPanel;
    public GameObject GfxPanel;
    public GameObject IntensidadPanel;
    public GameObject AusenciaPanel;
    public GameObject TimepoPanel;
    public GameObject AjustePanel;
    public GameObject EspectroPanel;
    public GameObject FrecuenciaPanel;
    public GameObject FonemasPanel;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

        //new key
        PlayerPrefs.SetInt("quickSaveSlot", quickSaveSlotID);
    }

    #region Open Different panels

    public void openOptions()
    {
        //enable respective panel
        MainOptionsPanel.SetActive(true);
        StartGameOptionsPanel.SetActive(false);

        //play anim for opening main options panel
        anim.Play("buttonTweenAnims_on");

        //play click sfx
        playClickSound();

        //enable BLUR
        //Camera.main.GetComponent<Animator>().Play("BlurOn");
       
    }

    public void openStartGameOptions()
    {
        //enable respective panel
        MainOptionsPanel.SetActive(false);
        StartGameOptionsPanel.SetActive(true);

        //play anim for opening main options panel
        anim.Play("buttonTweenAnims_on");

        //play click sfx
        playClickSound();

        //enable BLUR
        //Camera.main.GetComponent<Animator>().Play("BlurOn");
        
    }

    public void openOptions_Game()
    {
        //enable respective panel
        GamePanel.SetActive(true);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        IntensidadPanel.SetActive(false);
        AusenciaPanel.SetActive(false);
        TimepoPanel.SetActive(false);
        AjustePanel.SetActive(false);
        EspectroPanel.SetActive(false);
        FrecuenciaPanel.SetActive(false);
        FonemasPanel.SetActive(false);

    //play anim for opening game options panel
    anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }
    public void openOptions_Controls()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(true);
        GfxPanel.SetActive(false);
        IntensidadPanel.SetActive(false);
        AusenciaPanel.SetActive(false);
        TimepoPanel.SetActive(false);
        AjustePanel.SetActive(false);
        EspectroPanel.SetActive(false);
        FrecuenciaPanel.SetActive(false);
        FonemasPanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }
    public void openOptions_Gfx()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(true);
        IntensidadPanel.SetActive(false);
        AusenciaPanel.SetActive(false);
        TimepoPanel.SetActive(false);
        AjustePanel.SetActive(false);
        EspectroPanel.SetActive(false);
        FrecuenciaPanel.SetActive(false);
        FonemasPanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }

    public void openMenu_intensidad()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        IntensidadPanel.SetActive(true);
        AusenciaPanel.SetActive(false);
        TimepoPanel.SetActive(false);
        AjustePanel.SetActive(false);
        EspectroPanel.SetActive(false);
        FrecuenciaPanel.SetActive(false);
        FonemasPanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }

    public void openMenu_ausencia()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        IntensidadPanel.SetActive(false);
        AusenciaPanel.SetActive(true);
        TimepoPanel.SetActive(false);
        AjustePanel.SetActive(false);
        EspectroPanel.SetActive(false);
        FrecuenciaPanel.SetActive(false);
        FonemasPanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }

    public void openMenu_tiempo()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        IntensidadPanel.SetActive(false);
        AusenciaPanel.SetActive(false);
        TimepoPanel.SetActive(true);
        AjustePanel.SetActive(false);
        EspectroPanel.SetActive(false);
        FrecuenciaPanel.SetActive(false);
        FonemasPanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }

    public void openMenu_ajuste()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        IntensidadPanel.SetActive(false);
        AusenciaPanel.SetActive(false);
        TimepoPanel.SetActive(false);
        AjustePanel.SetActive(true);
        EspectroPanel.SetActive(false);
        FrecuenciaPanel.SetActive(false);
        FonemasPanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }

    public void openMenu_espectro()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        IntensidadPanel.SetActive(false);
        AusenciaPanel.SetActive(false);
        TimepoPanel.SetActive(false);
        AjustePanel.SetActive(false);
        EspectroPanel.SetActive(true);
        FrecuenciaPanel.SetActive(false);
        FonemasPanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }

    public void openMenu_freciencia()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        IntensidadPanel.SetActive(false);
        AusenciaPanel.SetActive(false);
        TimepoPanel.SetActive(false);
        AjustePanel.SetActive(false);
        EspectroPanel.SetActive(false);
        FrecuenciaPanel.SetActive(true);
        FonemasPanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }

    public void openMenu_fonemas()
    {
        //enable respective panel
        GamePanel.SetActive(false);
        ControlsPanel.SetActive(false);
        GfxPanel.SetActive(false);
        IntensidadPanel.SetActive(false);
        AusenciaPanel.SetActive(false);
        TimepoPanel.SetActive(false);
        AjustePanel.SetActive(false);
        EspectroPanel.SetActive(false);
        FrecuenciaPanel.SetActive(false);
        FonemasPanel.SetActive(true);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        playClickSound();

    }

    public void newGame()
    {
        if (!string.IsNullOrEmpty(newGameSceneName))
            SceneManager.LoadScene(newGameSceneName);
        else
            Debug.Log("Please write a scene name in the 'newGameSceneName' field of the Main Menu Script and don't forget to " +
                "add that scene in the Build Settings!");
    }
    #endregion

    #region Back Buttons

    public void back_options()
    {
        //simply play anim for CLOSING main options panel
        anim.Play("buttonTweenAnims_off");

        //disable BLUR
       // Camera.main.GetComponent<Animator>().Play("BlurOff");

        //play click sfx
        playClickSound();
    }

    public void back_options_panels()
    {
        //simply play anim for CLOSING main options panel
        anim.Play("OptTweenAnim_off");
        
        //play click sfx
        playClickSound();

    }

    public void Quit()
    {
        Application.Quit();
    }
    #endregion

    #region Sounds
    public void playHoverClip()
    {
       
    }

    void playClickSound() {

    }


    #endregion
}
