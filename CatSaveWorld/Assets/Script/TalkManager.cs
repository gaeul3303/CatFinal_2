using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    public GameObject professor1;
    public GameObject professor2;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();

    }

    void GenerateData()
    {
        //학생
        talkData.Add(1000, new string[] { "안녕? 너 혹시 내가 부른 그 고양이야? ", "내가 불러놓고 미안한데... \n 난 지금 대화할 시간이 없어." , "과제를 빨리 내야 하는데 내가 노트북을 옆에 있는 공원에서 잃어버렸어. \n 빨리 찾아야해.", "혹시 날 좀 도와줄 수 있을까? 네가 노트북을 찾아준다면 \n 제보한 내용에 대해 자세히 알려줄게.", "좋다는거지? 그럼 부탁좀 할게.",
        "노트북을 찾으면 날 찾아와줘. \n (마우스 왼쪽 버튼을 누르면 노트북 획득!)"});
        //학생2
        talkData.Add(1500, new string[] { "진짜 찾아줬구나! 고마워. 이제 제보에 대한 얘기를 해줄게.","얼마 전부터 우리 학교에 있던 고양이들이 사라지기 시작했어.",
        "그런데 사라지기 시작한 시점부터 \n 악덕 교수가 고양이들이 사라져서 좋다는 얘기를 하더라고.", "조용해서 수업하기 좋다느니… 그 핑계로 과제와 쪽지시험이 엄청 늘어났고.",
        "그래서 악덕만교수가 고양이를 납치한다는 소문이 돌기도 했어.","교수는 앞 도로에서 왼쪽으로 쭉 직진하면 큰 빨간 건물에 있어. \n 미안하지만 한번 더 부탁할게. 고양이들을 되찾아줘!"});
        //교수
        talkData.Add(2000, new string[] { "뭐냐? 왜 갑자기 날..너도 재수강 듣고 싶냐?", "뭐? 고양이를 찾고 있다고?\n 그런데 너… 고양이 주제에 말을 하는군..한 번 시험해보고 싶구나.","너에게도 나의 쪽지시험을 내줘야겠어. \n만일 풀지 못한다면 넌 나의 대학원생이 되어야 한다." });
        //교수
        talkData.Add(2500, new string[] { "영특한 고양이 같으니라고..\n이제 학생들을 괴롭히지 않겠어. 약속하지! 과제도 안내겠다고.", "흠… 이 학교에 고양이들이 어떻게 됐는지가 알고싶어서 왔지?", "사실 난 고양이들을 없애지 않았어. \n그저 고양이가 없어지자 학생들이 한눈 팔 곳이 없어지니까..공부에 더 집중하지 않을까 해서..",
        "하지만 대학생들은 고양이가 없다고 수업에 집중하지 않더군… \n내가 너무 큰 기대를 했어.","그런 줄도 모르고 고양이들을 데려가는 그 사람을  지켜만 봤다니.\n 참 부끄럽구만.",
        "어떤 외부인이 공원 옆에 있는 주차장으로 가는 것을 봤어. \n그 이후 그 고양이는 보이지 않더군. 일주일 단위로 학교에 찾아오던데?","그 사람을 잡으려면 도망가지 않게 돌같은걸 던져서 아무것도 못하게 해봐","아마 돌을 맞으면 도망가려 할거야.\n 그 사람이 도망치기 전에 잡아야 해. 행운을 빌게",
        "(밖으로 나가 수상한 사람이 보이면 마우스 왼쪽 키를 누르세요)"});

        //범인
        talkData.Add(3000, new string[] { "악! 죄송해요..." });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
        {

            if (id == 2000)
            {
                //씬 전환
                SceneManager.LoadScene("ProfessorScene");
                return null;
            }
            else
            {
                return null;
            }
        }
        else
            return talkData[id][talkIndex];
        
    }
}
