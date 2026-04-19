public class Solution {
    public void Rotate(int[] nums, int k) {
        k=k%nums.Length;
        if(k==0)return; 
        int hcf= HCF(nums.Length,k);
        System.Console.WriteLine(hcf);
        for(int i=0;i<hcf;i++){
            int s=i+k, n=nums[i];
            do{
                int d =nums[s];
                nums[s]=n;
                n=d;
                s=(s+ k) % nums.Length;
            }while(s!=i);
            nums[s]=n;
        }
    }
    public static int HCF(int n1, int n2){
        if(n1<n2)
        return HCF(n2,n1);
        if(n1%n2==0) return n2;
        return HCF(n2,(n1%n2));
    }
}