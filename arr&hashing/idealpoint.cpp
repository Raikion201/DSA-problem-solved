#include <algorithm>
#include <iostream>
#include <string>
#include <stdio.h>
using namespace std;

void YES(bool b){
    string t; t = (b ? "YES" : "NO");
    cout << t << "\n" ;
}
void solve(){
    int n , k;
    cin >> n >> k;
    cout << "tetcase" << n << k << endl;
    int fll = 0 ,flr=0;
    int l ,r,i = 0;
    while(  n-- ){
        cin >> l >> r;
        if(l == k) fll = 1;
        if(r == k) flr = 1;
    }
    YES(fll && flr);
}

int main(){
    int t; cin >> t;
    while( t-- )
        solve();
}
