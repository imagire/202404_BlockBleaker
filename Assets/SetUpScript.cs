using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpScript : MonoBehaviour
{
    // Start is called before the first frame update
    // �I�u�W�F�N�g�𐶐����錳�ƂȂ�Prefab�ւ̎Q�Ƃ�ێ����܂��B
    public GameObject prefabObj;

    // ���������I�u�W�F�N�g�̐e�I�u�W�F�N�g�ւ̎Q�Ƃ�ێ����܂��B
    public Transform parentTran;
    public static int block_number;
    int row;
    int column;
    float xOffset;
    float yOffset;

    void Start()
    {
        row = 2;
        column = 3;
        block_number = 6;
        xOffset = 30f;
        yOffset = 30f;
        CreateBlockObject();
        BallScript.blocks = block_number;
    }

    void Update()
    {
        if (BallScript.blocks <= 0)
        {
            stage2create();
            BallScript.blocks = block_number;
        }
    }
    /// <Summary>
    /// Prefab����u���b�N�Ƃ��Ďg���I�u�W�F�N�g�𐶐����܂��B
    /// </Summary>
    void CreateBlockObject()
    {
        
        for (int j = 0; j < row; j++)
        {
            for (int i = 0; i < column; i++)
            {
                // �Q�[���I�u�W�F�N�g�𐶐����܂��B
                GameObject obj = Instantiate(prefabObj, Vector3.zero, Quaternion.identity);

                // �Q�[���I�u�W�F�N�g�̐e�I�u�W�F�N�g��ݒ肵�܂��B
                obj.transform.SetParent(parentTran);

                // �Q�[���I�u�W�F�N�g�̈ʒu��ݒ肵�܂��B
                float xPos = xOffset * i;
                float yPos = yOffset * j;
                obj.transform.localPosition = new Vector3(xPos - 30, yPos, 0.5f);
            }
        }
    }

    public void stage2create()
    {
        row = 5;
        column = 4;
        block_number = 20;
        xOffset = 20f;
        yOffset = 10f;
        CreateBlockObject();
    }
}

