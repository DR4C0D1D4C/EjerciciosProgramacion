using UnityEngine;

public class MyVector3
{
    private float x, y, z, magnitude;

    public MyVector3()
    {
        x = 0f;
        y = 0f;
        z = 0f;
        magnitude = 0f;
    }

    public MyVector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public float Magnitude()
    {
        if (this.magnitude > 0f)
            return this.magnitude;
        else
        {
            this.magnitude = Mathf.Sqrt(x * x + y * y + z * z);
            return magnitude;
        }
    }

    public MyVector3 Add(MyVector3 vec)
    {
        float x3 = vec.x + this.x;
        float y3 = vec.y + this.y;
        float z3 = vec.z + this.z;
        MyVector3 vec3 = new MyVector3(x3, y3, z3);
        return vec3;
    }

    public float ProductoEscalar(MyVector3 vec)
    {
        float producto = vec.x * this.x + vec.y * this.y + vec.z * this.z;
        return producto;
    }

    public MyVector3 Normilize(MyVector3 vec)
    {
        if (vec.magnitude < 0f)
        {
            vec.magnitude = Magnitude();
        }

        float x = vec.x / vec.magnitude;
        float y = vec.y / vec.magnitude;
        float z = vec.z / vec.magnitude;

        MyVector3 normalizedVec = new MyVector3(x, y, z);

        return normalizedVec;
    }
}
