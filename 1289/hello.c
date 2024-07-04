
#include<stdio.h>
#include<unistd.h>
#include<sys/types.h>
int main() 
{
	int a;
	printf("\nPID : %d\nPPid : %d\n",getpid(),getppid());
	scanf("%d",&a);
	return 0;
		
}
