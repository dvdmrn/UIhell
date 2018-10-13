using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour {

List<GameObject> lineList = new List<GameObject>();

    private DD_DataDiagram m_DataDiagram;
    public InteractionsPerMin ipm;

    //private RectTransform DDrect;
    private float m_Input;

    public float freq = 2f;

    void AddALine(string name, Color color) {

        if (null == m_DataDiagram)
            return;

        GameObject line = m_DataDiagram.AddLine(color.ToString(), color);
        if (null != line)
            lineList.Add(line);
    }

    // Use this for initialization
    void Start () {

        GameObject dd = GameObject.Find("DataDiagram");
        if(null == dd) {
            Debug.LogWarning("can not find a gameobject of DataDiagram");
            return;
        }
        m_DataDiagram = dd.GetComponent<DD_DataDiagram>();

        m_DataDiagram.PreDestroyLineEvent += (s, e) => { lineList.Remove(e.line); };

        // AddALine();
        AddALine("BLOOD",new Color(0.6f, 0.2f, 0.3f));
        AddALine("IPM",new Color(0.9f, 0.4f, 0.9f));
        AddALine("INTERACTION_DENSITY",new Color(0.6f, 0.6f, 1f));
        // AddALine("SEROTONIN",new Color(0.6f, 0.5f, 0.8f));

        // new Color(1f, 0.4f, 0.5f)
        // print(lineList[0]);
        // print(lineList[1]);
        

        
    }



    private void FixedUpdate() {

        m_Input += Time.deltaTime;
        ContinueInput(m_Input);
    }

    private void ContinueInput(float f) {

        if (null == m_DataDiagram)
            return;

        

            m_DataDiagram.InputPoint(lineList[0], new Vector2(0.4f,
                            Mathf.PerlinNoise(0.5f, f * (ipm.interactionDensity*0.1f))*50f));
            
            // interactions per min
            m_DataDiagram.InputPoint(lineList[1], new Vector2(0.5f,
                                    ipm.ipm));
            
            // interaction density
            m_DataDiagram.InputPoint(lineList[2], new Vector2(0.5f,
                                    ipm.interactionDensity));
            // m_DataDiagram.InputPoint(lineList[3], new Vector2(0.08f,
            //                 (Mathf.Sin(Mathf.Tan(f)*Mathf.PerlinNoise(1f,f))*0.55f)+0.5f));

            // m_DataDiagram.InputPoint(lineList[0], new Vector2(0.1f,
            //                 Mathf.Pow(Mathf.Sin(freq*f),155)*(Mathf.Sin(freq*f+7.82f)*8)+0.5f));
    }


}



    


