https://github.com/element-plus/element-plus/blob/dev/packages/theme-chalk/src/common/var.scss

https://github.com/DapperLib/Dapper/blob/main/Directory.Build.props

https://element-plus.gitee.io/zh-CN/component/button.html


    <el-button round>Round</el-button>
    <el-button type="primary" round>Primary</el-button>
    <el-button type="success" round>Success</el-button>
    <el-button type="info" round>Info</el-button>
    <el-button type="warning" round>Warning</el-but

    <el-button type="primary" plain>Primary</el-button>
    <el-button type="success" plain>Success</el-button>
    <el-button type="info" plain>Info</el-button>
    <el-button type="warning" plain>Warning</el-button>

<button class="el-button el-button--primary is-plain" aria-disabled="false" type="button"><!--v-if--><span class="">Primary</span></button>


element.style {
}
.el-button--primary.is-plain, .el-button--primary.is-text, .el-button--primary.is-link {
    --el-button-text-color: var(--el-color-primary);
    --el-button-bg-color: var(--el-color-primary-light-9);
    --el-button-border-color: var(--el-color-primary-light-5);
    --el-button-hover-text-color: var(--el-color-white);
    --el-button-hover-bg-color: var(--el-color-primary);
    --el-button-hover-border-color: var(--el-color-primary);
    --el-button-active-text-color: var(--el-color-white);
}
.el-button.is-plain {
    --el-button-hover-text-color: var(--el-color-primary);
    --el-button-hover-bg-color: var(--el-fill-color-blank);
    --el-button-hover-border-color: var(--el-color-primary);
}




element.style {
}
.el-button+.el-button {
    margin-left: 12px;
}
.el-button--primary {
    --el-button-text-color: var(--el-color-white);
    --el-button-bg-color: var(--el-color-primary);
    --el-button-border-color: var(--el-color-primary);
    --el-button-outline-color: var(--el-color-primary-light-5);
    --el-button-active-color: var(--el-color-primary-dark-2);
    --el-button-hover-text-color: var(--el-color-white);
    --el-button-hover-link-text-color: var(--el-color-primary-light-5);
    --el-button-hover-bg-color: var(--el-color-primary-light-3);
    --el-button-hover-border-color: var(--el-color-primary-light-3);
    --el-button-active-bg-color: var(--el-color-primary-dark-2);
    --el-button-active-border-color: var(--el-color-primary-dark-2);
    --el-button-disabled-text-color: var(--el-color-white);
    --el-button-disabled-bg-color: var(--el-color-primary-light-5);
    --el-button-disabled-border-color: var(--el-color-primary-light-5);
}
.el-button {
    display: inline-flex;
    justify-content: center;
    align-items: center;
    line-height: 1;
    height: 32px;
    white-space: nowrap;
    cursor: pointer;
    color: var(--el-button-text-color);
    text-align: center;
    box-sizing: border-box;
    outline: none;
    transition: .1s;
    font-weight: var(--el-button-font-weight);
    user-select: none;
    vertical-align: middle;
    -webkit-appearance: none;
    background-color: var(--el-button-bg-color);
    border: var(--el-border);
    border-color: var(--el-button-border-color);
    padding: 8px 15px;
    font-size: var(--el-font-size-base);
    border-radius: var(--el-border-radius-base);
}




.el-button--primary.is-plain, .el-button--primary.is-text, .el-button--primary.is-link {
    --el-button-text-color: var(--el-color-primary);
    --el-button-bg-color: var(--el-color-primary-light-9);
    --el-button-border-color: var(--el-color-primary-light-5);
    --el-button-hover-text-color: var(--el-color-white);
    --el-button-hover-bg-color: var(--el-color-primary);
    --el-button-hover-border-color: var(--el-color-primary);
    --el-button-active-text-color: var(--el-color-white);
}
.el-button.is-text {
    color: var(--el-button-text-color);
    border: 0 solid transparent;
    background-color: transparent;
}

el-button.is-round {
    border-radius: var(--el-border-radius-round);
}
.el-button.is-round {
    padding: 8px 15px;
}
.el-button+.el-button {
    margin-left: 12px;
}
.el-button--primary {
    --el-button-text-color: var(--el-color-white);
    --el-button-bg-color: var(--el-color-primary);
    --el-button-border-color: var(--el-color-primary);
    --el-button-outline-color: var(--el-color-primary-light-5);
    --el-button-active-color: var(--el-color-primary-dark-2);
    --el-button-hover-text-color: var(--el-color-white);
    --el-button-hover-link-text-color: var(--el-color-primary-light-5);
    --el-button-hover-bg-color: var(--el-color-primary-light-3);
    --el-button-hover-border-color: var(--el-color-primary-light-3);
    --el-button-active-bg-color: var(--el-color-primary-dark-2);
    --el-button-active-border-color: var(--el-color-primary-dark-2);
    --el-button-disabled-text-color: var(--el-color-white);
    --el-button-disabled-bg-color: var(--el-color-primary-light-5);
    --el-button-disabled-border-color: var(--el-color-primary-light-5);
}
