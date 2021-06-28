# AutoWorkCheck

### 개요

출퇴근 도장으로 자동으로 찍어주는 웹 매크로. 매일 아침, 출근 버튼을 누르는 것이 귀찮으시지는 않습니까?  
인터넷을 고, 사이트를 이동하고, 아이디와 비밀번호를 쳐야하는 번거로움을 줄이기 위해서 원클릭 시스템을 배포합니다.

### 요구 사항

- 크롬 드라이버를 사용하기 때문에, PC에 크롬이 설치되어 있어야 합니다.
- 자신의 그룹웨어 계정정보가 필요합니다.
- 그룹웨어의 'My Desk'가 활성화되어 있어야 하며, 출퇴근 관리 항목이 설정되어있어야 합니다. 
![Screenshot_2021-06-10_01](https://user-images.githubusercontent.com/38543277/121486074-c7c59d80-ca0b-11eb-8aa9-7303e81610fe.png)

### 그룹웨어 설정방법

1) MyDesk가 없는 경우  
    우측 하단의 MyDesk 버튼을 클릭한다.  
    ![MyDesk](https://user-images.githubusercontent.com/38543277/121486445-1b37eb80-ca0c-11eb-9a8f-a2b63580d3e2.png)  
2) 출퇴근 관리 항목이 없는 경우  
    1. MyDesk의 좌측 상단에 환경설정을 누른다.  
    ![Config](https://user-images.githubusercontent.com/38543277/121486719-5cc89680-ca0c-11eb-9bf0-9330b2e9aa9e.png)  
    2. 출퇴근관리 항목에 체크를 한다.  
    ![Check](https://user-images.githubusercontent.com/38543277/121486776-68b45880-ca0c-11eb-8018-ccb3fd17fa42.png)  
    3. 출퇴근관리 항목을 드래그해서 상단으로 올린다.  

### 프로그램 실행 방법

1. Resource 폴더 안에 Account.json 파일을 열고, 아이디와 비밀번호를 입력하고 저장한다.
2. 출근 시에는 On.bat 파일을, 퇴근 시에는 Off.bat 파일을 실행한다.

### 기타 팁

#### 빠른 실행 방법
1. On.bat 또는 Off.bat 파일을 마우스 오른쪽 버튼으로 누르고, 바로가기 만들기를 클릭해서 바로가기를 만든다.
2. 이름을 ".bat - 바로가기"를 지우고, "On" 또는 "Off"가 되도록 수정한다.
3. 해당 바로가기 파일을 "C:\Windows\System32"으로 옮긴다. 옮기는 과정에서 관리자 권한을 요구할 수도 있다.
4. 윈도우 + R 버튼을 눌러 실행 창을 열고, On 또는 Off 를 입력 후 실행한다.
