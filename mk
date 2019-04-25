pushd src
gcc main.c debug.c reciter.c render.c sam.c -o sam
popd
mv src/sam .
