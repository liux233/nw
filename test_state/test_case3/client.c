#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>

#define PORT 8321
#define IP "127.0.0.1"

int main() {

    int sockfd = socket(AF_INET, SOCK_STREAM, 0);
    if(sockfd == -1) {
        printf("create sockfd err\n");
        exit(1);
    }

    struct linger linger;
    linger.l_onoff = 1;
    linger.l_linger = 0;
    int ret = setsockopt(sockfd, SOL_SOCKET, SO_LINGER, (const char *)&linger, sizeof(linger));
    if(ret != 0){
        printf("set linger err\n");
        exit(1);
    }

    struct sockaddr_in server;
    bzero(&server, sizeof(server));
    server.sin_family = AF_INET;
    server.sin_port = htons(PORT);
    server.sin_addr.s_addr = inet_addr(IP);

    ret = connect(sockfd, (struct sockaddr *)&server, sizeof(server));
    if(ret == -1) {
        printf("connect server err\n");
        exit(1);

    }
    
    printf("connect ok\n");
    sleep(2);
    int i = 1000;
    char *msg = "test_statekjhfdsahishfiuifdb@&*$^*";
    while(i--) {
        ret = send(sockfd, msg, strlen(msg), 0);
        if(ret == -1) {
            printf("send err\n");
            goto err;
        }
        
        usleep(10 * 1000);
    }
    printf("send finish\n");
    sleep(5);

    close(sockfd);
    return 0;

err:
    close(sockfd);
    return -1;
}
