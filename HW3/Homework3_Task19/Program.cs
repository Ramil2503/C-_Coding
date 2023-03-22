Console.Clear();
string s = Console.ReadLine()!;
int j = s.Length - 1, cnt = 0;

for (int i = 0; i < s.Length / 2; i++) {
    if (s[i] != s[j]) {
        cnt++;
        break;
    }
    j--;
}

if (cnt == 0)
    Console.Write("YES");
else
    Console.Write("NO");
