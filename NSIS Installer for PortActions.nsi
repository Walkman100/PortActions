; PortActions Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

;Icon "My Project\.ico"
Caption "PortActions Installer"
Name "PortActions"
AutoCloseWindow true
ShowInstDetails show

LicenseBkColor /windows
LicenseData "LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing PortActions. If you understand the notice, click the checkbox below and click Next."

InstallDir $PROGRAMFILES\WalkmanOSS

OutFile "bin\Release\PortActions-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\PortActions.exe"
  WriteUninstaller "PortActions-Uninst.exe"
SectionEnd

Section "Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\WalkmanOSS"
  CreateShortCut "$SMPROGRAMS\WalkmanOSS\PortActions.lnk" "$INSTDIR\PortActions.exe" "" "$INSTDIR\PortActions.exe" "" "" "" "PortActions"
  CreateShortCut "$SMPROGRAMS\WalkmanOSS\Uninstall PortActions.lnk" "$INSTDIR\PortActions-Uninst.exe" "" "" "" "" "" "Uninstall PortActions"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "Desktop Shortcut"
  CreateShortCut "$DESKTOP\PortActions.lnk" "$INSTDIR\PortActions.exe" "" "$INSTDIR\PortActions.exe" "" "" "" "PortActions"
SectionEnd

Section "Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\PortActions.lnk" "$INSTDIR\PortActions.exe" "" "$INSTDIR\PortActions.exe" "" "" "" "PortActions"
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install PortActions. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/Walkman100/PortActions/blob/master/README.md#portactions-"
    NoReadme:
FunctionEnd

; Uninstaller

Section "Uninstall"
  Delete "$INSTDIR\PortActions-Uninst.exe"   ; Remove Application Files
  Delete "$INSTDIR\PortActions.exe"
  RMDir "$INSTDIR"
  
  Delete "$SMPROGRAMS\WalkmanOSS\PortActions.lnk"   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\WalkmanOSS\Uninstall PortActions.lnk"
  RMDir "$SMPROGRAMS\WalkmanOSS"
  
  Delete "$DESKTOP\PortActions.lnk"   ; Remove Desktop Shortcut
  Delete "$QUICKLAUNCH\PortActions.lnk"   ; Remove Quick Launch Shortcut
SectionEnd

; Uninstaller Functions

Function un.onInit
    MessageBox MB_YESNO "This will uninstall PortActions. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
    SetShellVarContext all
    SetAutoClose true
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd
