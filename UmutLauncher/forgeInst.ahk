#Requires AutoHotkey v2.0

if (A_Args[4]!="true"){
    MsgBox A_Args[4]
    ExitApp
}
ZipDir := A_ScriptDir "\" StrReplace(A_Args[1],"/","\") 
TempDir := A_Args[2]
DestDir := A_Args[3]
if (A_Args.Length < 7){
    InfoL := {
        forgeLink: A_Args[5]
    }
}else{
    InfoL := {
        forgeLink: A_Args[5],
        isModsExternal: A_Args[6],
        externalModsLink: A_Args[7]
    }
}
if(!FileExist("unzip.exe")){
    Download("http://stahlworks.com/dev/unzip.exe", "unzip.exe")
}
DirCreate(ZipDir "\..")
Download(InfoL.forgeLink, ZipDir)
DirCreate(TempDir)
RunWait("unzip.exe " ZipDir, TempDir, "Hide")
FileDelete(ZipDir)
DirCopy(TempDir,DestDir,true)
DirDelete(TempDir, true)
 
