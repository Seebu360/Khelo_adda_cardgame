﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static PlayerManager instance;

    [SerializeField]
    private PlayerGameDetails playerGameData = null; // contains user details


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        playerGameData = PrefsManager.GetPlayerData();
    }

    public void DeletePlayerGameData()
    {
        playerGameData = null;
    }

    public PlayerGameDetails GetPlayerGameData()
    {
        return playerGameData;
    }

    public void SetPlayerGameData(PlayerGameDetails dataToAssign)
    {
        playerGameData = dataToAssign;
        PrefsManager.SetPlayerGameData(playerGameData);
    }

    public bool IsLogedIn()
    {
        if (playerGameData.userId.Length > 0)
        {
            //UnityEngine.Debug.Log("playerGameData.userId :" + playerGameData.userId);
            return true;
        }

        return false;
    }

}

[System.Serializable]
public class PlayerGameDetails
{
    public string userId;
    public string userName;
    public string fullName;
    public string nickName;
    public string userEmail;
    public string userDob;
    public string userMobile;
    public string userAddress;
    public string userGender;
    public string password;
    public string avatarURL,FrameUrl,CountryURL;
    public string referralCode;
    public string userLevel;
    public string countryName;
    public string countryCode;
    public float coins, diamonds, points, real;
    public int rabit, emoji, time;
    public bool isSilverCardPurchased;
    public bool isBronzeCardPurchased;
    public bool isPlatinumCardPurchased;
    public string registrationType;
    public string isEmailVerified;
    public string isMobileVerified;
    public Sprite userPic;
    public int avatarID;
    public int frameID;
    public string token;
}
