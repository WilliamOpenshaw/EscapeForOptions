using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class memeMarketController : MonoBehaviour
{
    public bool memeMarketOpen;
    public GameObject memePanel;
    public int lastMemeViewed = -1;
    public GameObject currentMemeNumberText;
    public GameObject memeWindow;
    public AssignFirstMeme memeAssigner;
    public bool[] memePickedUp;
    public int firstTrueMemeNum;
    public int[][] memeIndex;
    public long[] memeShares;

    public float sharesAvg;
    public float sharesSum;

    public float sharePercentage;
    public GameObject memeOverallPerformanceText;

    public GameObject memePriceText;

    public GameObject memeSharesTotalValueText;

    public GameObject memeSharesText;
    public MemeGraph graphDrawer;
    public long playerCash;
    public GameObject playerCashText;
    public int currOffSet;
    public UnityEngine.Object[] memePicFilesArray;
    public GameObject blackBlocker;
    public GameObject controlsMenu;
    public GameObject donationInfo;
    public GameObject ghostIsland;
    public GameObject rNGesus;
    public GameObject breakIsland;
    public GameObject spaceship;
    public GameObject enemySpawnIsland;

    public GameObject ghostIslandMessage;
    public GameObject rN;
    public GameObject bI;
    public GameObject sS;
    public GameObject eS;


    void Start()
    {
        
        donationInfo.SetActive(false);
        ghostIsland.SetActive(false);
        rNGesus.SetActive(false);
        breakIsland.SetActive(false);
        spaceship.SetActive(false);
        enemySpawnIsland.SetActive(false);
        blackBlocker.SetActive(false);
        memePicFilesArray = Resources.LoadAll("MemePics", typeof(Texture));
        memeMarketOpen = false;
        memePanel.SetActive(false);
        memePickedUp = new bool[memePicFilesArray.Length + 3];
        for (int i = 0; i < memePickedUp.Length; i++)
        {
            memePickedUp[i] = false;
            //memePickedUp[i] = true;
        }
        memeIndex = new int[memePicFilesArray.Length + 3][];
        for (int p = 0; p < memeIndex.Length; p++)
        {
            memeIndex[p] = new int[20];
            for (int c = 0; c < memeIndex[p].Length; c++)
            {
                if (c == 0)
                {
                    memeIndex[p][c] = UnityEngine.Random.Range(1, 201);
                }
                else
                {
                    memeIndex[p][c] += UnityEngine.Random.Range(-20, 20);
                    if (memeIndex[p][c] < 1)
                    {
                        memeIndex[p][c] = 0;
                    }
                }
            }
        }
        memeShares = new long[memePicFilesArray.Length + 3];
        lastMemeViewed = -1;
        currOffSet = 0;
        playerCash = 1;
        sharesSum = 0;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
        {
            Application.Quit();
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && controlsMenu.activeSelf == true)
        {

            controlsMenu.SetActive(false);

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && controlsMenu.activeSelf == false)
        {
            controlsMenu.SetActive(true);
        }
        if (memeMarketOpen == false)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                blackBlocker.SetActive(true);
                memeMarketOpen = true;
                memePanel.SetActive(true);
                //find first picked up meme
                if (lastMemeViewed == -1)
                {
                    for (int z = 0; z < memePickedUp.Length; z++)
                    {
                        if (memePickedUp[z] == true)
                        {
                            sharesSum = 0;
                            firstTrueMemeNum = z;
                            lastMemeViewed = firstTrueMemeNum;
                            memeWindow.GetComponent<RawImage>().texture = (Texture)memePicFilesArray[lastMemeViewed];
                            currentMemeNumberText.GetComponent<Text>().text = lastMemeViewed.ToString();
                            graphDrawer.ShowGraph(memeIndex[lastMemeViewed]);
                            memeSharesText.GetComponent<Text>().text = memeShares[z].ToString();
                            memePriceText.GetComponent<Text>().text = "$" + memeIndex[z][19].ToString();
                            memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[z][19] * memeShares[z]).ToString();
                            for (int p = 0; p < memeIndex[z].Length - 1; p++)
                            {
                                sharesSum += memeIndex[z][p];
                            }
                            sharesAvg = (sharesSum) / (memeIndex[z].Length - 1);
                            sharePercentage = (((100 * memeIndex[z][19]) / sharesAvg) - 100);
                            if (sharePercentage > -1)
                            {
                                memeOverallPerformanceText.GetComponent<Text>().text = "+" + sharePercentage.ToString("0.0") + "%";
                            }
                            else if (sharePercentage < 0)
                            {
                                memeOverallPerformanceText.GetComponent<Text>().text = sharePercentage.ToString("0.0") + "%";
                            }
                            playerCashText.GetComponent<Text>().text = "$" + playerCash.ToString();
                            break;
                        }
                    }
                }
                else
                {
                    graphDrawer.ShowGraph(memeIndex[lastMemeViewed]);
                }
            }
        }
        else if (memeMarketOpen == true)
        {
            if (Input.GetKeyDown(KeyCode.O) && lastMemeViewed != -1)
            {
                for (int z = lastMemeViewed + 1; z < memePickedUp.Length; z++)
                {
                    if (z >= memePickedUp.Length - 1)
                    {
                        z = -1;
                    }
                    else if (z == lastMemeViewed)
                    {
                        break;
                    }
                    else if (memePickedUp[z] == true)
                    {
                        sharesSum = 0;
                        firstTrueMemeNum = z;
                        lastMemeViewed = firstTrueMemeNum;
                        memeWindow.GetComponent<RawImage>().texture = (Texture)memePicFilesArray[lastMemeViewed];
                        currentMemeNumberText.GetComponent<Text>().text = lastMemeViewed.ToString();
                        graphDrawer.ShowGraph(memeIndex[lastMemeViewed]);
                        memeSharesText.GetComponent<Text>().text = memeShares[z].ToString();
                        memePriceText.GetComponent<Text>().text = "$" + memeIndex[z][19].ToString();
                        memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[z][19] * memeShares[z]).ToString();
                        for (int p = 0; p < memeIndex[z].Length - 1; p++)
                        {
                            sharesSum += memeIndex[z][p];
                        }
                        sharesAvg = (sharesSum) / (memeIndex[z].Length - 1);
                        sharePercentage = (((100 * memeIndex[z][19]) / sharesAvg) - 100);
                        if (sharePercentage > -1)
                        {
                            memeOverallPerformanceText.GetComponent<Text>().text = "+" + sharePercentage.ToString("0.0") + "%";
                        }
                        else if (sharePercentage < 0)
                        {
                            memeOverallPerformanceText.GetComponent<Text>().text = sharePercentage.ToString("0.0") + "%";
                        }
                        break;
                    }
                }
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                for (int z = lastMemeViewed - 1; z >= -1; z--)
                {
                    if (z <= -1)
                    {
                        z = memePickedUp.Length - 2;
                    }
                    else if (z == lastMemeViewed)
                    {
                        break;
                    }
                    if (memePickedUp[z] == true)
                    {
                        sharesSum = 0;
                        firstTrueMemeNum = z;
                        lastMemeViewed = firstTrueMemeNum;
                        memeWindow.GetComponent<RawImage>().texture = (Texture)memePicFilesArray[lastMemeViewed];
                        currentMemeNumberText.GetComponent<Text>().text = lastMemeViewed.ToString();
                        graphDrawer.ShowGraph(memeIndex[lastMemeViewed]);
                        memeSharesText.GetComponent<Text>().text = memeShares[z].ToString();
                        memePriceText.GetComponent<Text>().text = "$" + memeIndex[z][19].ToString();
                        memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[z][19] * memeShares[z]).ToString();
                        for (int p = 0; p < memeIndex[z].Length - 1; p++)
                        {
                            sharesSum += memeIndex[z][p];
                        }
                        sharesAvg = (sharesSum) / (memeIndex[z].Length - 1);
                        sharePercentage = (((100 * memeIndex[z][19]) / sharesAvg) - 100);
                        if (sharePercentage > -1)
                        {
                            memeOverallPerformanceText.GetComponent<Text>().text = "+" + sharePercentage.ToString("0.0") + "%";
                        }
                        else if (sharePercentage < 0)
                        {
                            memeOverallPerformanceText.GetComponent<Text>().text = sharePercentage.ToString("0.0") + "%";
                        }
                        break;
                    }
                }
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                memeMarketOpen = false;
                memePanel.SetActive(false);
                blackBlocker.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.J))
            {
                //Buy 1
                if (playerCash >= memeIndex[lastMemeViewed][19] && playerCash != 0 && memeIndex[lastMemeViewed][19] >= 0)
                {
                    if (memeIndex[lastMemeViewed][19] == 0)
                    {
                        playerCash -= 1;
                    }
                    else
                    {
                        playerCash -= memeIndex[lastMemeViewed][19];
                    }

                    memeShares[lastMemeViewed] += 1;
                    memeSharesText.GetComponent<Text>().text = memeShares[lastMemeViewed].ToString();
                    playerCash = Math.Abs(playerCash);
                    playerCashText.GetComponent<Text>().text = "$" + playerCash.ToString();
                    memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[lastMemeViewed][19] * memeShares[lastMemeViewed]).ToString();
                }
                playerCash = Math.Abs(playerCash);
            }
            else if (Input.GetKey(KeyCode.Y))
            {
                //Buy 20
                if (playerCash >= memeIndex[lastMemeViewed][19] * (playerCash / 5) && playerCash != 0 && playerCash > 20 && memeIndex[lastMemeViewed][19] >= 0)
                {
                    memeShares[lastMemeViewed] += Math.Abs(playerCash / 2);
                    playerCash -= Math.Abs((memeIndex[lastMemeViewed][19] * (playerCash / 5)) + (playerCash / 2));
                    memeSharesText.GetComponent<Text>().text = memeShares[lastMemeViewed].ToString();
                    playerCashText.GetComponent<Text>().text = "$" + playerCash.ToString();
                    memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[lastMemeViewed][19] * memeShares[lastMemeViewed]).ToString();

                }
                else if (playerCash >= memeIndex[lastMemeViewed][19] && playerCash != 0 && memeIndex[lastMemeViewed][19] >= 0)
                {
                    if (memeIndex[lastMemeViewed][19] == 0)
                    {
                        playerCash -= 1;
                    }
                    playerCash -= memeIndex[lastMemeViewed][19];
                    memeShares[lastMemeViewed] += 1;
                    memeSharesText.GetComponent<Text>().text = memeShares[lastMemeViewed].ToString();
                    playerCash = Math.Abs(playerCash);
                    playerCashText.GetComponent<Text>().text = "$" + playerCash.ToString();
                    memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[lastMemeViewed][19] * memeShares[lastMemeViewed]).ToString();
                }
                playerCash = Math.Abs(playerCash);
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                //Sell 1
                if (memeShares[lastMemeViewed] >= 1 && memeIndex[lastMemeViewed][19] >= 0)
                {
                    memeShares[lastMemeViewed] -= 1;
                    playerCash += (memeIndex[lastMemeViewed][19]);
                    memeSharesText.GetComponent<Text>().text = memeShares[lastMemeViewed].ToString();
                    playerCash = Math.Abs(playerCash);
                    playerCashText.GetComponent<Text>().text = "$" + playerCash.ToString();
                    memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[lastMemeViewed][19] * memeShares[lastMemeViewed]).ToString();
                }
                playerCash = Math.Abs(playerCash);
                if (playerCash > 999 && ghostIsland.activeSelf == false)
                {
                    ghostIsland.SetActive(true);
                    ghostIslandMessage.SetActive(false);
                }
                if (playerCash > 19999 && rNGesus.activeSelf == false)
                {
                    rNGesus.SetActive(true);
                    rN.SetActive(false);
                }
                if (playerCash > 2999999 && breakIsland.activeSelf == false)
                {
                    breakIsland.SetActive(true);
                    bI.SetActive(false);
                }
                if (playerCash > 399999999999 && spaceship.activeSelf == false)
                {
                    spaceship.SetActive(true);
                    sS.SetActive(false);
                }
                if (playerCash > 9223299999999999999 && enemySpawnIsland.activeSelf == false)
                {
                    enemySpawnIsland.SetActive(true);
                    eS.SetActive(false);
                }
            }
            else if (Input.GetKey(KeyCode.P))
            {
                //Sell 20 
                if (memeShares[lastMemeViewed] > 20 && memeIndex[lastMemeViewed][19] >= 0)
                {
                    playerCash = Math.Abs(playerCash + (memeIndex[lastMemeViewed][19] * (memeShares[lastMemeViewed] / 2)));
                    memeShares[lastMemeViewed] = Math.Abs((memeShares[lastMemeViewed] / 2) - memeShares[lastMemeViewed]);

                    memeSharesText.GetComponent<Text>().text = memeShares[lastMemeViewed].ToString();
                    playerCash = Math.Abs(playerCash);
                    playerCashText.GetComponent<Text>().text = "$" + playerCash.ToString();
                    memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[lastMemeViewed][19] * memeShares[lastMemeViewed]).ToString();
                }
                else if (memeShares[lastMemeViewed] >= 1 && memeIndex[lastMemeViewed][19] >= 0)
                {
                    memeShares[lastMemeViewed] -= 1;
                    playerCash += (memeIndex[lastMemeViewed][19]);
                    memeSharesText.GetComponent<Text>().text = memeShares[lastMemeViewed].ToString();
                    playerCash = Math.Abs(playerCash);
                    playerCashText.GetComponent<Text>().text = "$" + playerCash.ToString();
                    memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[lastMemeViewed][19] * memeShares[lastMemeViewed]).ToString();
                }
                playerCash = Math.Abs(playerCash);
                if (playerCash > 999 && ghostIsland.activeSelf == false)
                {
                    ghostIsland.SetActive(true);
                    ghostIslandMessage.SetActive(false);
                }
                if (playerCash > 19999 && rNGesus.activeSelf == false)
                {
                    rNGesus.SetActive(true);
                    rN.SetActive(false);
                }
                if (playerCash > 2999999 && breakIsland.activeSelf == false)
                {
                    breakIsland.SetActive(true);
                    bI.SetActive(false);
                }
                if (playerCash > 399999999999 && spaceship.activeSelf == false)
                {
                    spaceship.SetActive(true);
                    sS.SetActive(false);
                }
                if (playerCash > 9223299999999999999 && enemySpawnIsland.activeSelf == false)
                {
                    enemySpawnIsland.SetActive(true);
                    eS.SetActive(false);
                }
            }
        }
    }
    public void MarketUpdate()
    {
        currOffSet += 1;
        for (int p = 0; p < memeIndex.Length; p++)
        {
            for (int c = 0; c < memeIndex[p].Length; c++)
            {
                if (c != 19)
                {
                    memeIndex[p][c] = memeIndex[p][c + 1];
                }
                else
                {
                    memeIndex[p][c] += UnityEngine.Random.Range(-20, 20);
                    if (memeIndex[p][c] < 0)
                    {
                        memeIndex[p][c] = 0;
                    }
                }
            }
        }

        sharesSum = 0;

        currentMemeNumberText.GetComponent<Text>().text = lastMemeViewed.ToString();
        graphDrawer.ShowGraph(memeIndex[lastMemeViewed]);
        memeSharesText.GetComponent<Text>().text = memeShares[lastMemeViewed].ToString();
        memePriceText.GetComponent<Text>().text = "$" + memeIndex[lastMemeViewed][19].ToString();
        memeSharesTotalValueText.GetComponent<Text>().text = "$" + (memeIndex[lastMemeViewed][19] * memeShares[lastMemeViewed]).ToString();
        for (int p = 0; p < memeIndex[lastMemeViewed].Length - 1; p++)
        {
            sharesSum += memeIndex[lastMemeViewed][p];
        }
        sharesAvg = (sharesSum) / (memeIndex[lastMemeViewed].Length - 1);
        sharePercentage = (((100 * memeIndex[lastMemeViewed][19]) / sharesAvg) - 100);
        if (sharePercentage >= 0)
        {
            memeOverallPerformanceText.GetComponent<Text>().text = "+" + sharePercentage.ToString("0.0") + "%";
        }
        else if (sharePercentage < 0)
        {
            memeOverallPerformanceText.GetComponent<Text>().text = sharePercentage.ToString("0.0") + "%";
        }
    }

}
