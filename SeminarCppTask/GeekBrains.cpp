#include <stdio.h>

int f(int Person1_Speed, int Person2_Speed, int Dog_Speed, int distance)
{
	int ans, cnt, time;
	while (distance > 10)
	{
		time = distance / (Person2_Speed + Dog_Speed);
		distance = distance - (time * (Person1_Speed + Person2_Speed));
		if (distance > 10)
		{
			time = distance / (Person1_Speed + Dog_Speed);
			distance = distance - (time * (Person2_Speed + Person1_Speed));
			cnt++;
		}
		cnt++;
	}
	return cnt;
}

int main()
{
	int Person1_Speed, Person2_Speed, Dog_Speed, distance;
	scanf("%d %d %d %d", &Person1_Speed, &Person2_Speed, &Dog_Speed, &distance);
	printf("%d", f(Person1_Speed, Person2_Speed, Dog_Speed, distance));
	return 0;
}