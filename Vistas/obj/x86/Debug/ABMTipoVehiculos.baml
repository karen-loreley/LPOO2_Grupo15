   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas   Vistas.ABMTipoVehiculos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	     � Title$  ABMTipoVehiculos��5   	   $	��300��6"   $	��542��6/    � 	Resources 5       S� 
ObjectType!   ClasesBase.TrabajarVehiculo S� 
MethodName   list_vehiculo��%Q   &	        S� 5   
   "  5      $ traerTipoVehiculos��5	      5
      5      .��5   
   � $	��515��6   .+�5   
   �� -   5        $��
btnaceptar��5   ^   $��Guardar��6   $��23��6#   $
��Left=�6/   $��
12,222,0,0q�6J   $	��Top=�6p   $��75��6�     buttonvehiculo#��[ 6�   �� 5   
   -   5        $��codigo��5   [   $��Codigo��6   $��28��6!   $
��Left=�6-   $��	12,66,0,0q�6H   $	��Top=�6i   �� 5   
   -   5        $��descripcion��5   a   $��Descripcion��6   $��28��6&   $
��Left=�62   $��
12,119,0,0q�6M   $	��Top=�6t   �� 5   
   -   5        $��tarifa��5   \   $��Tarifa��6   $��28��6!   $
��Left=�6-   $��
12,169,0,0q�6H   $	��Top=�6j   �� 5   
   -   5        $��
textcodigo��5   L   $��23��6   $
��Left=�6   $��	84,72,0,0q�69   $	��Top=�6^   $	��120��6v   �� 5   
   -   5        $��textdescripcion��5   M   $��23��6   $
��Left=�6   $��
84,119,0,0q�69   $	��Top=�6d   $	��120��6|   �� 5   
   -   5        $��
texttarifa��5   M   $��23��6   $
��Left=�6   $��
84,169,0,0q�69   $	��Top=�6_   $	��120��6w   �� 5   
   -   5        $��btnmodificar��5   `   $��	Modificar��6   $��23��6%   $
��Left=�61   $��
93,223,0,0q�6L   $	��Top=�6t   $��75��6�   #��[ 6�   �� 5   
   -	   5        $��btneliminar��5   `   $��Eliminar��6   $��23��6$   $
��Left=�60   $��174,222,0,0q�6K   $	��Top=�6s   $��75��6�   #��[ 6�   �� 5   
   -
   5        $��vehiculo��5   ^   $��Vehiculo��6   $��35��6#   $
��Left=�6/   $��
192,12,0,0q�6J   $	��Top=�6n   $��20(�6�   $��86��6�   �� 5   
   -   5        $��btnplaya��5   p   $��Playa de Estacionamiento��6   $��30��64   $
��Left=�6@   $��301,219,0,0q�6[   $	��Top=�6�   $	��202��6�   #��[ 6�   �� 5   
   -   5        $��	vehiculos��5      $	��142��6$   $��210,55,12,64q�61   ��5      ��  �� Source# [   �� View 5      �� 5      .P�5      ��  �� Width$ 70��6%   $��Codigo��60    �� DisplayMemberBinding 6@   ��  �� Path$ TVCodigo��� 5       $	 147��6%   $��Descripcion��61    6F   �� $ Descripcion��� 5!      $ 70��6%   $��Tarifa��60    6@   �� $ Tarifa�5"      5$      5&      5'      