using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class MemeGraph : MonoBehaviour
{
    [SerializeField] private Sprite circleSprite;
    private RectTransform graphContainer;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    private RectTransform dashTemplateX;
    private RectTransform dashTemplateY;
    public memeMarketController memeIndexScript;

    
    
    private void Awake()
    {
        graphContainer = transform.Find("graphContainer").GetComponent<RectTransform>();
        labelTemplateX = graphContainer.Find("labelTemplateX").GetComponent<RectTransform>();
        labelTemplateY = graphContainer.Find("labelTemplateY").GetComponent<RectTransform>();
        dashTemplateX = graphContainer.Find("dashTemplateX").GetComponent<RectTransform>();
        dashTemplateY = graphContainer.Find("dashTemplateY").GetComponent<RectTransform>();        
    }
    /*
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ShowGraph(memeIndexScript.memeIndex[memeIndexScript.lastMemeViewed]);
        }
    }
    */
    private GameObject CreateCircle(Vector2 anchoredPosition)
    {
        var gameObject = new GameObject("circle", typeof(Image));
        gameObject.tag = "Graph";
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSprite;
        gameObject.GetComponent<Image>().useSpriteMesh = true;
        var rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }
    //public void ShowGraph(int[] valueList, int graphMemeNum)
    public void ShowGraph(int[] valueList)  
    //public void ShowGraph(List<float> valueList)
    {
        EraseGraph();
        
        graphContainer.localPosition = new Vector3(0.0155f*graphContainer.sizeDelta.x,0,0);
        graphContainer.sizeDelta = new Vector2( gameObject.GetComponent<RectTransform>().rect.width * 0.965f, gameObject.GetComponent<RectTransform>().rect.height * 0.87f);
        float graphHeight = graphContainer.sizeDelta.y;       

        //float yMaximum = Mathf.Max(valueList[graphMemeNum]) + (Mathf.Max(valueList[graphMemeNum])/10);
        float yMaximum = Mathf.Max(valueList) + (Mathf.Max(valueList)/10);
        //float yMaximum = Mathf.Max(valueList.ToArray()) + (Mathf.Max(valueList.ToArray())/10);

        float xSize = (float)((0.97*graphContainer.sizeDelta.x)/(valueList.Length));
        //var xSize = (790f/(valueList.Length));
        //float xSize = (790f/(valueList.Count));
        GameObject lastCircleGameObject = null;
        for (int i = 0; i < valueList.Length; i++)
        {
            float xPosition = (float)((xSize/2) + i * xSize);

            //float yPosition = (valueList[graphMemeNum][i]/ yMaximum) * graphHeight;
            float yPosition = (valueList[i]/ yMaximum) * graphHeight;

            var circleGameobject = CreateCircle(new Vector2(xPosition, yPosition));
            circleGameobject.tag = "Graph";
            if (lastCircleGameObject != null)
            {
                CreateDotConnection(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition, circleGameobject.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircleGameObject = circleGameobject;
            
            var labelX = Instantiate(labelTemplateX);
            labelX.tag = "Graph";
            labelX.SetParent(graphContainer, false);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(xPosition + 1f, -15f);
            labelX.GetComponent<Text>().text = (i + memeIndexScript.currOffSet).ToString();
            
            var dashX = Instantiate(dashTemplateX);
            dashX.tag = "Graph";
            dashX.SetParent(graphContainer, false);
            dashX.gameObject.SetActive(true);
            dashX.anchoredPosition = new Vector2(xPosition, -6f);
        }
        var seperatorCount = 10;
        for (var i = 0; i <= seperatorCount; i++)
        {
            RectTransform labelY = Instantiate(labelTemplateY);
            labelY.tag = "Graph";
            labelY.SetParent(graphContainer, false);
            labelY.gameObject.SetActive(true);
            float normalizedValue = i * 1f / seperatorCount;
            labelY.anchoredPosition = new Vector2(-14f, normalizedValue * graphHeight);
            labelY.GetComponent<Text>().text = Mathf.RoundToInt( normalizedValue * yMaximum).ToString();
            
            RectTransform dashY = Instantiate(dashTemplateY);
            dashY.tag = "Graph";
            dashY.SetParent(graphContainer, false);
            dashY.gameObject.SetActive(true);
            dashY.anchoredPosition = new Vector2(-10f, normalizedValue * graphHeight);
        }
    }
    private void CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.tag = "Graph";
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        var rectTransform = gameObject.GetComponent<RectTransform>();
        var dir = (dotPositionB - dotPositionA).normalized;
        var distance = Vector2.Distance(dotPositionA, dotPositionB);
        rectTransform.sizeDelta = new Vector2(distance, 3f);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.anchoredPosition = dotPositionA + .5f * distance * dir;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }

    private void EraseGraph()
    {
        for (var i = 0; i < GameObject.FindGameObjectsWithTag("Graph").Length; i++)
        {
            Destroy(GameObject.FindGameObjectsWithTag("Graph")[i]);
        }        
    }
}
