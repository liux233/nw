#!/bin/bash

while :
do
    sleep 1
    date +%F-%H:%M:%S
    netstat -tpn 2> /dev/null | grep "127.0.0.1" 
done
