using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCodeMesh : MonoBehaviour {

    public Material material;

    private void Start()
    {
        Vector3[] vertices = new Vector3[4];
        Vector2[] uvs = new Vector2[4];
        int[] triangleSides = new int[6];

        vertices[0] = new Vector3(0,0);
        vertices[1] = new Vector3(0,1);
        vertices[2] = new Vector3(1,0);
        vertices[3] = new Vector3(1,1);

        uvs[0] = new Vector2(0,0);
        uvs[1] = new Vector2(0,1);
        uvs[2] = new Vector2(1,0);
        uvs[3] = new Vector2(1,1);

        triangleSides[0] = 0;
        triangleSides[1] = 1;
        triangleSides[2] = 2;

        triangleSides[3] = 2;
        triangleSides[4] = 1;
        triangleSides[5] = 3;

        Mesh newMesh = new Mesh();

        newMesh.vertices = vertices;
        newMesh.uv = uvs;
        newMesh.triangles = triangleSides;

        GameObject gameObjectMesh = new GameObject("Mesh", typeof(MeshFilter), typeof(MeshRenderer), typeof(MeshCollider));
        gameObjectMesh.transform.localScale = new Vector3(1, 1, 1);

        gameObjectMesh.GetComponent<MeshFilter>().mesh = newMesh;

        gameObjectMesh.GetComponent<MeshRenderer>().material = material;
    }


}
