﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameDataEditor;

public class ButtonFuctions : MonoBehaviour {

    [SerializeField] Animator cameraAnimator;
    [SerializeField] GameObject cameraParent;
    [SerializeField] GameObject[] abilitiesImages;
    [SerializeField] GameObject[] characterInfoImages;
    [SerializeField] GameObject chooseCharacterScreen;
    [SerializeField] Text characterDescription;
    [SerializeField] Text characterName;
    [SerializeField] Text melee;
    [SerializeField] Text distance;
    [SerializeField] Text magic;
    [SerializeField] Text experience;
    [SerializeField] Text level;


    private bool isActualMissionShowed;

    SceneLoadingController sceneController;
    GDEManager gdeManager;

    private void Awake()
    {
        //PlayerPrefs.SetInt("characterChoosen", 0);
        sceneController = FindObjectOfType<SceneLoadingController>();
        gdeManager = FindObjectOfType<GDEManager>();

        if (PlayerPrefs.GetInt("characterChoosen") == 0)
            chooseCharacterScreen.SetActive(true);
        else GDEManager.LoadPlayerData();
    }
    public void StartAdventure()
    {
        if(gdeManager.currentMission != null)
            sceneController.LoadScene(GameScene.Adventure, true);
    }
    public void GoToTavern()
    {
        cameraParent.transform.position = new Vector3(180.9f, -25.98f, -18.8f);
        cameraParent.transform.Rotate(new Vector3(0f, 25.3f, 0f));
        cameraAnimator.Play("GoToTavern");
    }
    public void GoToMainMenu()
    {
        cameraParent.transform.position = new Vector3(0f, 0f, 0f);
        cameraParent.transform.Rotate(new Vector3(0f, -25.3f, 0f));
        cameraAnimator.Play("GoToMainMenu");
    }
    public void SeeActualMissions()
    {
        if(!isActualMissionShowed)
        {
            isActualMissionShowed = true;
            cameraParent.transform.position = new Vector3(183.6f, -27.7f, -10.5f);
            cameraAnimator.Play("ShowMissions");
        }
        else
        {
            isActualMissionShowed = false;
            cameraParent.transform.position = new Vector3(180.9f, -25.98f, -18.8f);
            cameraAnimator.Play("BackFromMissionsBoard");
        }
    }
    public void GoToCharacterInfo()
    {
        characterDescription.text = System.String.Empty + GDEManager.character.characterDescription;
        characterName.text = System.String.Empty + GDEManager.character.characterName;
        melee.text = "Melee " + GDEManager.character.basicMelee;
        distance.text = "Distance " + GDEManager.character.basicDistance;
        magic.text = "Magic " + GDEManager.character.basicMagic;
        experience.text = "Experience " + GDEManager.character.experience;
        level.text = "Level " + GDEManager.character.level;
        cameraParent.transform.position = new Vector3(0f, -116f, 0f);
        cameraAnimator.Play("ShowCharacter");
    }
    public void BackToMenu()
    {
        cameraParent.transform.position = new Vector3(0f, 0f, 0f);
        cameraAnimator.Play("BackToMenu");
    }
    public void ShowAbilities()
    {
        foreach (GameObject item in characterInfoImages)
            item.SetActive(false);
        foreach(GameObject item in abilitiesImages)
            item.SetActive(true);
    }
    public void HideAbilities()
    {
        foreach (GameObject item in abilitiesImages) 
            item.SetActive(false);
        foreach (GameObject item in characterInfoImages)
            item.SetActive(true);
    }
    public void ChooseCharacter(int i)
    {
        PlayerPrefs.SetInt("characterChoosen", 1);
        GDEManager.SavePlayerData(i,true);
        //GDEManager.SaveData();
        chooseCharacterScreen.SetActive(false);
    }
    public void EnterTavern()
    {
        cameraAnimator.Play("EnterTavern");
    }
}
