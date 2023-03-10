using System;
using System.ComponentModel.DataAnnotations;

namespace testapi.Models;


public class Cluster{

    [Key]
    public int id {get; set;}
    public double[] mList {get;} = new double[155];

    public Cluster(object[] meta){
        id = Convert.ToInt32(meta[0]);
        for (int i = 1; i < meta.Count(); i++)
        {
            mList[i-1] = (Convert.ToDouble(meta[i]));
        }
    }

}