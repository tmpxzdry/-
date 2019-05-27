using System;

namespace _02
{
    class Node{
        public int val;
        public Node next;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list1=MakeList(0,2,2,4,6,8);
            var list2=MakeList(0,1,2,3,4,9,22);
            PrintList(list1);
            PrintList(list2);
            var result=Zip(list1,list2);
            PrintList(result);
        }

        static Node Zip(Node p,Node q){
            Node head=new Node(),zipper=head;
            while(p!=null&&q!=null){
                if(p.val<q.val){
                    zipper.next=p;
                    p=p.next;
                }else{
                    zipper.next=q;
                    q=q.next;
                }
                zipper=zipper.next;
            }
            zipper.next=p??q;
            return head.next;
        }
        static Node MakeList(params int[] a){
            Node head=null;
            for(int i=a.Length-1;i>=0;i--){
                head=new Node{val=a[i],next=head};
            }
            return head;
        }
        static void PrintList(Node list){
            while(list!=null){
                System.Console.Write($"{list.val}->");
                list=list.next;
            }
            System.Console.WriteLine("null");
        }
    }
}
