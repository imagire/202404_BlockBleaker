using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Vector3 mousePos, pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�}�E�X�̍��W���擾����S
        mousePos = Input.mousePosition;
        //�}�E�X�ʒu���m�F
        //Debug.Log(mousePos);
        //�X�N���[�����W�����[���h���W�ɕϊ�����
        pos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, 220, 116f));
        //���[���h���W���Q�[���I�u�W�F�N�g�̍��W�ɐݒ肷��
        transform.position = pos;
    }
}
