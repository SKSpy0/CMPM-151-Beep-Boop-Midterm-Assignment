using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    [SerializeField] private Material red;
    [SerializeField] private Material yellow;
    [SerializeField] private Material black;
    [SerializeField] private Material blue;
    [SerializeField] private Material purple;
    [SerializeField] private Material green;
    [SerializeField] private Material white;
    [SerializeField] private Material orange;

    private Material[] mats = new Material[8];

    [SerializeField] private Rotator pickup0;
    [SerializeField] private Rotator pickup1;
    [SerializeField] private Rotator pickup2;
    [SerializeField] private Rotator pickup3;
    [SerializeField] private Rotator pickup4;
    [SerializeField] private Rotator pickup5;
    [SerializeField] private Rotator pickup6;
    [SerializeField] private Rotator pickup7;

    private int color = 0;

    // Start is called before the first frame update
    void Start()
    {
        mats[0] = red;
        mats[1] = yellow;
        mats[2] = black;
        mats[3] = blue;
        mats[4] = purple;
        mats[5] = green;
        mats[6] = white;
        mats[7] = orange;

        ShuffleColors();

        pickup0.updateMat(mats[0]);
        pickup1.updateMat(mats[1]);
        pickup2.updateMat(mats[2]);
        pickup3.updateMat(mats[3]);
        pickup4.updateMat(mats[4]);
        pickup5.updateMat(mats[5]);
        pickup6.updateMat(mats[6]);
        pickup7.updateMat(mats[7]);

        ShuffleColors();

        this.GetComponent<Renderer>().material = mats[color];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShuffleColors()
    {
        for (int i = 0; i < mats.Length; i++)
        {
            int rnd = Random.Range(0, mats.Length);
            Material tempM = mats[rnd];
            mats[rnd] = mats[i];
            mats[i] = tempM;
        }
    }

    public Material getCurColor()
    {
        return mats[color];
    }

    public void updateColor()
    {
        color += 1;
        if(color < 8)
        {
            this.GetComponent<Renderer>().material = mats[color];
        }
    }
}
