declare global {
    interface System {
      import (request: string): Promise<any>
    }
    var System: System
}
import login from '../views/login.vue'
import home from '../views/home/home.vue'
import main from '../views/main.vue'
export const locking = {
    path: '/locking',
    name: 'locking',
    component: () => import('../components/lockscreen/components/locking-page.vue')
};
export const loginRouter = {
    path: '/',
    name: 'login',
    meta: {
        title: 'LogIn'
    },
    component:()=>import('../views/login.vue')
};
export const otherRouters={
    path:'/main',
    name:'main',
    permission:'',
    meta:{title:'ManageMenu'},
    component:main,
    children:[
        {path: 'home', meta:{title:'HomePage'}, name: 'home', component:()=>import('../views/home/home.vue')}
    ]
}
export const appRouters=[
    {
    path:'/setting',
    name:'setting',
    permission:'',
    meta:{title:'用户管理'},
    icon:'&#xe68a;',
    component:main,
    children:[
        {path: 'user',permission:'Pages.Users', meta:{title:'Users'}, name: 'user', component:()=>import('../views/setting/user/user.vue')},
        {path: 'role',permission:'Pages.Roles', meta:{title:'Roles'}, name: 'role', component:()=>import('../views/setting/role/role.vue')},
        {path: 'tenant',permission:'Pages.Tenants', meta:{title:'Tenants'}, name: 'tenant', component:()=>import('../views/setting/tenant/tenant.vue')}
    ]
    },
    {
        path:'/product',
        name:'product',
        permission:'',
        meta:{title:'商品管理'},
        icon:'&#xe68a;',
        component:main,
        children:[
            {path: 'pdbrand',permission:'Pages.PdBrand', meta:{title:'品牌管理'}, name: 'pdbrand', component:()=>import('../views/product/pdbrand/pdbrand.vue')},
        ]
        },
]
export const routers = [
    loginRouter,
    locking,
    ...appRouters,
    otherRouters
];
