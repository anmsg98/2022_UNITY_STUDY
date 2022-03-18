using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyA : MonoBehaviour
{
    private GameObject studyBGameObject;

    private void Start()
    {
        // studyBGameObject = GameObject.FindObjectOfType<StudyB>().gameObject;
        //
        //  // 오브젝트 생성
        //  studyBGameObject = new GameObject("B");
        //  studyBGameObject.AddComponent<StudyB>();
        //  studyBGameObject.AddComponent<StudyC>();
        //
        //  print(studyBGameObject.name);
        //
        //  var studyB = studyBGameObject.GetComponent<StudyB>();
        //  studyBGameObject.SendMessage("SayHello");
        //
        //  // 오브젝트 및 컨포넌트 삭제
        //  Destroy(studyBGameObject);

        var c = transform.Find("C");
        print(c.name);
    }
}
