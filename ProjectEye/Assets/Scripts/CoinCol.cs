using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

public class CoinCol : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        transform.position = TransformManager.Instance.MoveGameObject();

        Score.ScoreValue += 1;

        AnimImage.Instance.PlayAnim();

    }

}
