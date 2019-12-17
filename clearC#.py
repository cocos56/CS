import os
import shutil

aimedDir=['obj','bin','.vs']
aimedExt=['.suo']

c=0
for root,dirs,files in os.walk("."):
    for i in dirs:
        if i in aimedDir:
            dir=os.path.join(root,i)
            print(c, dir)
            shutil.rmtree(dir)
            c+=1
    for i in files:
        if os.path.splitext(i)[1] in aimedExt:
            file=os.path.join(root,i)
            print(c, file)
            os.remove(file)
            c+=1
input('删除完毕，请按回车键以退出。')