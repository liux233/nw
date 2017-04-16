
#test state 
：test the connection state, when:

1.client send some msg, but server not recv, then client send close -->client: fin_wait2, server: close_wait

2.client send msg until sendqueue not change, and server not recv too, then client send close -->client:fin_wait1, server:established

3.client set so_linger on timeout 0, then send some msg, but server not recv, then client send close-->client's and server's state is established until client send close, when client send close, the queue is clean, the client send reset, then return, so that no state.

4.client set so_linger on timeout 0, then send msg until the sendqueue not change, meanwhile server don't recv too, then client send close-->the result is same to case3.

netstat -tpn 
observe the state

file a is the result file


###########

it is also s simple client-server code

