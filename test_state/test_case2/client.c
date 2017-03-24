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
    printf("sockfd:%d\n", sockfd);

    struct sockaddr_in server;
    bzero(&server, sizeof(server));
    server.sin_family = AF_INET;
    server.sin_port = PORT;
    server.sin_addr.s_addr = inet_addr(IP);

    int ret = connect(sockfd, (struct sockaddr *)&server, sizeof(server));
    if(ret == -1) {
        printf("connect server err\n");
        exit(1);

    }
    
    printf("connect ok\n");
    sleep(2);
    int i = 95061;
    char *msg = "test_statekjhfdsahishfiuifdb@&*$^*";
    while(i--) {
        ret = send(sockfd, msg, strlen(msg), 0);
        if(ret == -1) {
            printf("send err\n");
            goto err;
        }
        printf("%d\n", i);
        usleep(1 * 1000);
    }
    printf("send finish\n");
    sleep(5);

    close(sockfd);
    return 0;

err:
    close(sockfd);
    return -1;
}
