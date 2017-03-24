//ok
#include <stdio.h>
#include <time.h>
int main(void)
{
    time_t timer;//time_t就是long int 类型
    struct tm *tblock;
    timer = time(NULL);
    tblock = localtime(&timer);
    printf("Local time is: %s\n", asctime(tblock));
    return 0;
}


//todo:find why err
//#include <sys/time.h>
//#include <stdio.h>
//
//int main() {
//    time_t now;
//    //time(&now);
//    now = time(NULL);
//    struct tm * tm;
//    //localtime_r(&now, tm);
//    tm = localtime(&now);
//    printf("time is:%s\n", asctime(tm));
//
//    return 0;
//}
