using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUpScript : MonoBehaviour
{
    private Vector3 EndPos;
    private Vector3 StartPos;
    private float DesiredDuration=1f;
    private float ElapsedTime;
    public Transform Player;
    // Start is called before the first frame update
    void Awake()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        EndPos = new Vector3(Player.position.x,Player.position.y+5.899947f, Player.position.z - 8.608948f);
        ElapsedTime += Time.deltaTime;
        float PerCentAge = ElapsedTime / DesiredDuration;
        Vector3 relativePos=Player.position-transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
        transform.position = Vector3.Lerp(StartPos,EndPos,PerCentAge);
        transform.rotation = Quaternion.Euler(8.4f, 0f, 0f);
    }
}
