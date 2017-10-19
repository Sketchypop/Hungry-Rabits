using UnityEngine;
using System.Collections;

public class background_move : MonoBehaviour {

    public Transform car;
    public Transform sky;
    public GameObject CarObj;
    public GameObject GreenRoad;
	public GameObject water;
	public GameObject Rock;
	public GameObject Rock2;
	public GameObject tree0;
	public GameObject tree1;
	public GameObject flower;
	public GameObject Gbush;
    private float xcheck = 50f;
    private float xcord = 280f;
    private float terrain = 500f;
    private bool SkyMove = true;
    private float xT = 434f;
	private float xTW = 0f;
    private bool firstRun = true;
	private int PrefCount = 0;
	private int PrefCheck = 0;
	private float BooleanRandomNumber = 0;
	private float BooleanRandomNumberRock = 0;
	private float rockSelect = 0;
	private float WaterWidth = 0;
	private float ObjectSelect;
	public GameObject GroundPiece1;
	public GameObject GroundPiece2;
	public GameObject GroundPiece3;

    // Use this for initialization
    void Start () {
        StartCoroutine(Example());
    }
	
	// Update is called once per frame
	void Update () {

        
		/*
        Vector3 locationC = GetComponent<Camera>().WorldToScreenPoint(car.position);
       //print("Car Xcord is "+locationC.x);
		//print("Car ycord is "+locationC.y);


        Vector3 locationS = GetComponent<Camera>().WorldToScreenPoint(sky.position);
         //print("Sky Xcord is " + locationS.x);
		//print("Sky ycord is " + SkyObj.transform.position.y);

        float distance = Vector3.Distance(car.position,sky.position);
        //print("Distanc between car and sky " + distance);

       if ((-locationS.x) >= terrain)
        {
			//print ("Create terrain");
			BooleanRandomNumber = Random.value;
			BooleanRandomNumber = BooleanRandomNumber*10;
			BooleanRandomNumberRock = Random.value;
			BooleanRandomNumberRock = BooleanRandomNumberRock*10;
			WaterWidth = Random.Range(40.0F, 79.0F);
			ObjectSelect = Random.Range(1.0F,40.0F);
			//print ("Random Boolean Number RRRRock is "+BooleanRandomNumberRock);

			if (PrefCount % 2 == 1) 
			{
				print ("Random Boolean Number is "+BooleanRandomNumber);
				if (BooleanRandomNumber>5){
					Vector3 posW = new Vector3(xT, -41f, 0);
					Instantiate(water, posW, Quaternion.identity);

					terrain += 400;
					xT += WaterWidth;
				}
				else
				{
					xT+=25;
					Vector3 pos = new Vector3(xT, -39.45f, 0);
					Instantiate(GreenRoad, pos, Quaternion.identity);

					terrain += 400;
					xT += 100;
				}
			}
			else
			{

				for (int i=1;i<=2;i++)
				{
					Vector3 pos = new Vector3(xT, -39.45f, 0);
					Instantiate(GreenRoad, pos, Quaternion.identity);

					if (BooleanRandomNumberRock>5 && i==1)
					{
						rockSelect = Random.value;
						rockSelect = rockSelect*10;
						//print ("rock part is entered");
						if (rockSelect>5){
							Vector3 posR = new Vector3(xT, -30.5f, 0);
							Instantiate(Rock, posR, Quaternion.identity);
						}
						else {
							Vector3 posR = new Vector3(xT, -30.5f, 0);
							Instantiate(Rock2, posR, Quaternion.identity);
						}


					}
					if(i==1)
						xT+=100;
					terrain += 400;
				}

				if (ObjectSelect<10){
					Vector3 postObj = new Vector3(xT, -25.0f, 0);
					Instantiate(tree0, postObj, Quaternion.identity);
				}
				else if(ObjectSelect<20 && ObjectSelect > 10) {
					Vector3 postObj = new Vector3(xT, -23.0f, 0);
					Instantiate(tree1, postObj, Quaternion.identity);
				}
				else if(ObjectSelect<30 && ObjectSelect>20) {
					Vector3 postObj = new Vector3(xT, -29.5f, 0);
					Instantiate(flower, postObj, Quaternion.identity);
				}
				else {
					Vector3 postObj = new Vector3(xT, -30.0f, 0);
					Instantiate(Gbush, postObj, Quaternion.identity);
				}
				xT += 75;
			}

			PrefCount ++;
			//print ("pref no is "+PrefCount);;
            //terrain += 400;
            //xT += 100;
			//if (PrefCount % 2 == 1) {
				//print ("PrefCount is odd "+PrefCount);
				//if (PrefCount!=1)
				//{
					//print ("Prefcount is greater than 1 "+PrefCount);
					//xTW = xT+79;
					//Vector3 posW = new Vector3(xTW, -41f, 0);
					//Instantiate(water, posW, Quaternion.identity);
					//xT+=79;
				//}

        }*/



		

    }

	/*void fixedUpdate(){
		if (PrefCount % 2 == 1) {
				print ("PrefCount is ODD");
			}
	}

	public void PrefCountFunc()
	{
		//if (PrefCount % 2 == 1)
			print ("Pref is Odd ");
	}*/

    IEnumerator Example()
    {
        //print("The time is"+Time.time);
        yield return new WaitForSeconds(5);
        //print("The time is" + Time.time);
    }

}
