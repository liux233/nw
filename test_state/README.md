
#test state 
test the connection state, when:
1.client send some msg, but server not recv, then client send close
2.client send msg until sendqueue not change, and server not recv too, then client send close

netstat -tpn 
observe the state

file a is the result

